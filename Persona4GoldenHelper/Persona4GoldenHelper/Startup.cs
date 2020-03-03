using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persona4GoldenHelper.Data;
using Persona4GoldenHelper.Service;

namespace Persona4GoldenHelper
{
    /// <summary>The web app startup configuration.</summary>
    public class Startup
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The web app configuration.</summary>
        public IConfiguration Configuration { get; }


        /*********
        ** Public Methods 
        *********/
        /// <summary>Construct an instance.</summary>
        /// <param name="configuration">The web app configuration.</param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>This method gets called by the runtime. Use this method to add services to the container.</summary>
        /// <param name="services">The service injection container.</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
                options.AddPolicy("AllowAll", policyBuilder =>
                    policyBuilder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                    )
                );

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddTransient<IApp, AppService>();
            services.AddTransient<IPersona, PersonaService>();
            services.AddTransient<IFusion, FusionService>();
            services.AddTransient<IShadow, ShadowService>();

            services.AddTransient<Seeder>();

            services.AddMvc();
        }

        /// <summary>This method gets called by the runtime. Use this method to configure the HTTP request pipeline.</summary>
        /// <param name="app">The application builder.</param>
        /// <param name="env">The hosting environment.</param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseCors("AllowAll");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(cfg =>
            {
                cfg.MapRoute("Default", template: "{action}", new { Controller = "App", Action = "Index" });
                cfg.MapRoute("Persona", template: "Personas/{action}", new { Controller = "Persona", Action = "Index" });
                cfg.MapRoute("Shadow", template: "Shadows/{action}", new { Controller = "Shadow", Action = "Index" });
                cfg.MapRoute("Api", template: "Api/{action}", new { Controller = "Api" });
            });

            using (var scope = app.ApplicationServices.CreateScope())
            {
                var seeder = scope.ServiceProvider.GetService<Seeder>();
                seeder.Seed();
            }
        }
    }
}
