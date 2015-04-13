using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.WebApi;
using Luis.MasteringExtJs.WebApi.Handlers;
using Luis.MasteringExtJs.WebApi.Mapping;
using Luis.MasteringExtJs.WebApi.Repository;

namespace Luis.MasteringExtJs.WebApi
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
        
            builder.RegisterType<AuthenticationHandler>().As<IAuthenticationHandler>().InstancePerLifetimeScope();
            builder.RegisterType<MenuHandler>().As<IMenuHandler>().InstancePerLifetimeScope();
            builder.RegisterType<UserHandler>().As<IUserHandler>().InstancePerLifetimeScope();
            builder.Register(x => new SakilaEntities()).InstancePerLifetimeScope();

            var container = builder.Build();

            var resolver = new AutofacWebApiDependencyResolver(container);

            GlobalConfiguration.Configuration.DependencyResolver = resolver;

            AutoMapperWebConfiguration.Configure();

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
