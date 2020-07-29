using Backend.obj.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Backend.Contracts;
using Backend.Contracts.HelperContracts;
using Backend.Data;
using Backend.Helpers;

namespace Backend
{
    public class Startup
    {
        private string _connectionString = null;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            _connectionString = Configuration["secretConnectionString"];

            services.AddMvc();

            services.AddDbContext<ApiContext>(conStr => 
            conStr.UseNpgsql(_connectionString));


            services.AddTransient<IDataSeed, DataSeed>();

            services.AddTransient<IListBuilder, ListBuilder>();

            services.AddTransient<IApiContext, ApiContext>();

            services.AddTransient<ICustomerHelper, CustomerHelper>();

            services.AddTransient<IOrderHelper, OrderHelper>();

            services.AddTransient<IRandomizer, Randomizer>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IDataSeed seed)
        {
            var nCustomers = 20;
            var nOrders = 1000;


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            seed.SeedData(nCustomers, nOrders);

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}");
            });

        }
    }
}
