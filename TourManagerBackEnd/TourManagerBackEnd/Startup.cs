using System.Threading.Tasks;
using Data.Core.Configuration;
using ElectronNET.API;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
//using Microsoft.EntityFrameworkCore;

//using Pomelo.EntityFrameworkCore.MySql.Infrastructure;


namespace TourManagerBackEnd
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddControllers().AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);;
            services.AddHttpClient();   
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "wwwroot";
            });
            services.AddDbContext<TourManagerContext>(x => x.UseSqlite("Data Source=TourManager.db;"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors(builder => builder
                .AllowAnyHeader()
                .AllowAnyMethod()
                .SetIsOriginAllowed((host) => true)
                .AllowCredentials()
            );
            app.UseCorsMiddleware();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            
            
            app.UseSpaStaticFiles();
            //app.UseSpa(spa => { spa.Options.SourcePath = "wwwroot"; });
            
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
            
            Task.Run(async () => await Electron.WindowManager.CreateWindowAsync());
        }
    }
}