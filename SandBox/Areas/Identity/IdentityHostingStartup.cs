using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SandBox.Areas.Identity.Data;
using SandBox.Data;

[assembly: HostingStartup(typeof(SandBox.Areas.Identity.IdentityHostingStartup))]
namespace SandBox.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<SandBoxDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("SandBoxDbContextConnection")));

                services.AddDefaultIdentity<SandBoxUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                })
                
                    .AddEntityFrameworkStores<SandBoxDbContext>();
            });
        }
    }
}