using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using AutoMapper;
using DshInterview.Domain;
using DshInterview.Dto;

namespace DshInterview
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            BootstrapMapper();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }

        private void BootstrapMapper()
        {
            Mapper.CreateMap<CustomerAggregate, CustomerDto>()
                .ForMember(x => x.CustomerName, action => action.MapFrom(src => src.CustomerName))
                .ForMember(x => x.CustomerSince, action => action.MapFrom(src => src.CustomerSince.ToShortDateString()))
                .ForMember(x => x.Description, action => action.MapFrom(src => src.Description))
                .ForMember(x => x.TotalSpent, action => action.MapFrom(src => src.TotalSpent));
        }
    }
}