using Autofac;
using Autofac.Integration.Mvc;
using PromotionEnginePOC.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace PromotionEnginePOC.DI
{
    public class AutofacConfig
    {
        public static void RegisterAutofac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // manual registration of types;
            builder.RegisterType<PromotionType1>().As<IPromotionType>().InstancePerRequest();


            // For property injection using Autofac
            // builder.RegisterType<QuoteService>().PropertiesAutowired();

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}