using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DshInterview.Domain;
using DshInterview.Dto;
using DshInterview.Services;
using AutoMapper;

namespace DshInterview.Controllers
{
    public class CustomersController : Controller
    {
        CustomerServices customerService = new CustomerServices();

        [HttpGet]
        public JsonResult HighValue()
        {            
            var customers = Mapper.Map<IList<CustomerAggregate>, IList<CustomerDto>>(customerService.GetHighValueCustomers());

            return Json(customers, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Save(CustomerAggregate customer)
        {
            customerService.Save(customer);

            return Json(true);
        }

    }
}
