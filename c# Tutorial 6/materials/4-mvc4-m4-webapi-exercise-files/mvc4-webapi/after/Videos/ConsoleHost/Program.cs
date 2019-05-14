using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.SelfHost;
using Videos.Controllers;

namespace ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new HttpSelfHostConfiguration("http://localhost:8000");

            config.Routes.MapHttpRoute(
                name: "DefaultApiRoute",
                routeTemplate: "hosted/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
                );

            using (var server = new HttpSelfHostServer(config))
            {                
                server.OpenAsync().Wait();

                Console.WriteLine("Ready!");

                Console.ReadLine();
            }  
        }
    }
}
