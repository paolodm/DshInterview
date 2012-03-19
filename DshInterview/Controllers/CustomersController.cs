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
        //
        // GET: /Customers/

        [HttpGet]
        public JsonResult HighValue()
        {
            CustomerServices customerService = new CustomerServices();

            var customers = Mapper.Map<IList<CustomerAggregate>, IList<CustomerDto>>(customerService.GetHighValueCustomers());

            return Json(customers, JsonRequestBehavior.AllowGet);
        }

    }
}
