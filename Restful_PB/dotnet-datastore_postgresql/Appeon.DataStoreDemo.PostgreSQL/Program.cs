using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Appeon.DataStoreDemo.PostgreSQL
{
    public class Program
    {
        
        //public static void Main(string[] args)
        //{
        //    CreateWebHostBuilder(args).Build().Run();
        //}
        
        //public static IHostBuilder CreateHostBuilder(string[] args) =>
        //    Host.CreateDefaultBuilder(args)
        //        .ConfigureWebHostDefaults(webBuilder =>
        //        {
        //            webBuilder.UseStartup<Startup>();
        //        })
        //        ;
        
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }
        
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseKestrel((x) =>
            {
                x.ListenAnyIP(16561);
                //x.ListenAnyIP(5010, y => y.UseHttps());
                x.Limits.MaxRequestBodySize = int.MaxValue;
            })
                .UseStartup<Startup>();
                
       
    }
}
