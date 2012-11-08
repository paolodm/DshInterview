using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DshInterview.Data;
using DshInterview.Domain;

namespace DshInterview.Services
{
    public class CustomerServices
    {
        public IList<CustomerAggregate> GetHighValueCustomers()
        {
            IList<CustomerAggregate> customers;

            using (SalesEntities entities = new SalesEntities())
            {
                var twoYearsPrior = DateTime.Now.AddYears(-2);
                var oneYearPrior = DateTime.Now.AddYears(-1);

                customers = (from c in entities.Customers                             
                             where c.CustomerSince <= twoYearsPrior &&
                             c.Sales.Any(x => x.SaleDate >= oneYearPrior && x.Amount > 10000) 
                                select new CustomerAggregate()
                                           {
                                               CustomerID = c.CustomerID, 
                                               CustomerName = c.CustomerName, 
                                               CustomerSince = c.CustomerSince, 
                                               Description = c.Description, TotalSpent = c.Sales.Sum(x => x.Amount)
                                           }).ToList();                
            }

            return customers;
        }

        public void Save(CustomerAggregate customer)
        {
            using (SalesEntities entities = new SalesEntities())
            {
                entities.Customers.Attach(
                    new Customer() 
                    { 
                        CustomerID = customer.CustomerID, 
                        CustomerName = customer.CustomerName, 
                        CustomerSince = customer.CustomerSince, 
                        Description = customer.Description
                    }
                );
            }

        }
    }
}
