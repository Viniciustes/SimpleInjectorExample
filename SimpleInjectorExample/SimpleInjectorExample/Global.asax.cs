using SimpleInjector.Integration.Web.Mvc;
using SimpleInjectorExample.SimpleInjector;
using System.Web.Mvc;
using System.Web.Routing;

namespace SimpleInjectorExample
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //Configuração "startup" do SimpleInjector
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(SimpleInjectorContainerConfig.Config()));
        }
    }
}
