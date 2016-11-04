using Hackathon.Infra.Repositorio;
using Hackathon.Infra.Repositorio.Interface;
using Hackathon.Infra.UnitOfWork;
using Hackathon.Service.Service;
using Hackathon.Service.Service.Interface;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;

namespace Hackathon.Api
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<ITesteRepository, TesteRepository>();
            container.RegisterType<ITesteService, TesteService>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();


            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}