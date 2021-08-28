using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotsite.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Npgsql;

namespace Hotsite
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
            services.AddControllersWithViews();
            services.AddDbContext<DatabaseContext>(options =>
            {
                string _connectionString = Environment.GetEnvironmentVariable("DATABASE_URL");
                _connectionString.Replace("//", "");

                char[] delimiterChars = { '/', ':', '@', '?' };
                string[] strConn = _connectionString.Split(delimiterChars);
                strConn = strConn.Where(x => !string.IsNullOrEmpty(x)).ToArray();

                var user = strConn[1];
                var pass = strConn[2];
                var server = strConn[3];
                var database = strConn[5];
                var port = strConn[4];
                string ConnectionString = "host=" + server + ";port=" + port + ";database=" + database + ";uid=" + user + ";pwd=" + pass + ";sslmode=Require;Trust Server Certificate=true;Timeout=1000";

                options.UseNpgsql(ConnectionString);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            loggerFactory.AddFile("Logs/meulog-{Date}.txt");
        }
    }
}
