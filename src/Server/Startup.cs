namespace Server
{
    using Owin;
    using System.Web.Http;

    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder) 
        { 
            var httpConfiguration = new HttpConfiguration(); 
            httpConfiguration.Routes.MapHttpRoute( 
                name: "DefaultApi", 
                routeTemplate: "api/{controller}/{id}", 
                defaults: new { id = RouteParameter.Optional });

            appBuilder.UseWebApi(httpConfiguration); 
            appBuilder.MapSignalR();
        } 
    }
}