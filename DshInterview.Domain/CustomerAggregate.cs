using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DshInterview.Domain
{
    public class CustomerAggregate
    {
        public  int CustomerID
        {
            get;
            set;
        }

        public  string CustomerName
        {
            get;
            set;
        }

        public  string Description
        {
            get;
            set;
        }

        public  System.DateTime CustomerSince
        {
            get;
            set;
        }

        public decimal TotalSpent { get; set; }
    }
}
