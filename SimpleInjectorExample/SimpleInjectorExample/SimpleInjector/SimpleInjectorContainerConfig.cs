using SimpleInjector;
using SimpleInjectorExample.Application.Interfaces;
using SimpleInjectorExample.Application.Services;
using SimpleInjectorExample.Domain.Interfaces.Repositories;
using SimpleInjectorExample.Infrastructure.Repositories;
using SimpleInjectorExample.Services.Interfaces;
using SimpleInjectorExample.Services.Services;

namespace SimpleInjectorExample.SimpleInjector
{
    //Necessário instalação atravéz do Package Manage Console do Simple Injector
    //Install-Package SimpleInjector.Integration.Web.Mvc
    //Necessário chamar a classe no Global.asax do projeto no método Application_Start
    public static class SimpleInjectorContainerConfig
    {
        public static Container Config()
        {
            var container = new Container();

            container.Register<IAppProduct, AppProduct>(Lifestyle.Singleton);
            container.Register<IServiceProduct, ServiceProduct>(Lifestyle.Singleton);
            container.Register<IProductRepository, RepositoryProduct>(Lifestyle.Singleton);

            container.Verify();

            return container;
        }
    }
}