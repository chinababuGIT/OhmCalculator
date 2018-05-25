using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity;
using HomeDepot.Ohm.Provider;
using HomeDepot.Ohm.Model;
using System.Web.Mvc;
using HomeDepotOhmCalculator;
using HomeDepotOhmCalculator.Infrastructure;
namespace HomeDepotOhmCalculator.App_Start
{
    public static class IocConfiguration
    {
        
        public static void ConfigureIocContainer()
        {
            IUnityContainer _container = new UnityContainer();
            registerServices(_container);
            DependencyResolver.SetResolver(new OhmUnityDependencyResolver(_container));
        }

        private static void registerServices(IUnityContainer _unityContainer)
        {
            _unityContainer.RegisterType<IOhmCalculator, OhmCalculator>();
            _unityContainer.RegisterType<IOhmColorStaticValues, OhmColorStaticValues>();
            //_unityContainer.RegisterType<IResistenceValues, ResistenceValues>();
        }
    }
}