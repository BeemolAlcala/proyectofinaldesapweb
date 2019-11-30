using System;
using EquiposDeFutbol.Areas.Identity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(EquiposDeFutbol.Areas.Identity.IdentityHostingStartup))]
namespace EquiposDeFutbol.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<dvdCollectionContext>(options =>
                    options.UseSqlite(
                        context.Configuration.GetConnectionString("dvdCollectionContextConnection")));

                services.AddDefaultIdentity<User>()
                    .AddEntityFrameworkStores<dvdCollectionContext>();
            });
        }
    }
}