using SnapObjects.Data;
using SnapObjects.Data.AspNetCore;
using SnapObjects.Data.PostgreSql;
using Appeon.DataStoreDemo.PostgreSQL.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO.Compression;
using Microsoft.Extensions.Hosting;
using DWNet.Data.AspNetCore;

namespace Appeon.DataStoreDemo.PostgreSQL
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        
        public IConfiguration Configuration { get; }
        
        public void ConfigureServices(IServiceCollection services)
        {
            // services.AddMvc(m =>
            //{
            //m.UseCoreIntegrated();
            // m.UsePowerBuilderIntegrated();
            //});
            services.AddMvc(m =>
           {
               m.UseCoreIntegrated();
               m.UsePowerBuilderIntegrated();
               m.EnableEndpointRouting = false;
           });
            //Note: Change "OrderContext" if you have changed the default DataContext file name; change the "AdventureWorks" if you have changed the database connection name in appsettings.json
            services.AddDataContext<OrderContext>(m => m.UsePostgreSql(Configuration["ConnectionStrings:PB Postgres"]));
            
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ISalesOrderService, SalesOrderService>();
            services.AddScoped<IAddressService, AddressService>();
            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<IOrderReportService, OrderReportService>();
            
            services.AddGzipCompression(CompressionLevel.Fastest);
        }
        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (app is null)
            {
                throw new System.ArgumentNullException(nameof(app));
            }
            
            if (env is null)
            {
                throw new System.ArgumentNullException(nameof(env));
            }
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                //app.UseHsts();
            }
            //app.UseHttpsRedirection();
            
            app.UseResponseCompression();
            
            
            app.UseMvc();
            
            app.UseDataWindow();
        }
    }
}

