using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SandBox.Areas.Identity.Data;
using SandBox.Data;
using SandBox.Interfaces;
using SandBox.Mocks;
using SandBox.Repository;

namespace SandBox
{
    public class Startup
    {
        private IConfigurationRoot _confString;
        public Startup(IWebHostEnvironment hostingEnvironment)
        {
            _confString = new ConfigurationBuilder().SetBasePath(hostingEnvironment.ContentRootPath).AddJsonFile("appsettings.json").Build();
        }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddMvc();
            services.AddDbContext<SandBoxDbContext>(ops => ops.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MVCSandBoxDB;Trusted_Connection=True;MultipleActiveResultSets=true"));
            services.AddSession();
            services.AddTransient<IAllDoramas, DoramasRepository>();
            services.AddTransient<IDoramasCategory, CategoryRepository>();
            services.AddDbContext<AppDBContent>(ops => ops.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=DoramasU;Trusted_Connection=True;MultipleActiveResultSets=true"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
                DbObjects.Initial(content);
            }

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllerRoute(
                    name: "default", 
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
