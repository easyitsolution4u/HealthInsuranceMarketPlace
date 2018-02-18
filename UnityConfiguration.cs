using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectDosApplication.Repository;
using Unity;
using Unity.AspNet.Mvc;

namespace ProjectDosApplication.Infrastructure
{
    public class UnityConfiguration
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();
            container.RegisterType<IRecipientRepository, ReceipientRepository>();
            container.RegisterType<IAddressRepository, AddressRepository>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}