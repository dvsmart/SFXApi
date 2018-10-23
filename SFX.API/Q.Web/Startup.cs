﻿using System;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using SFX.Infrastructure.Context;
using SFX.Services.Interfaces.Authentication;
using SFX.Services.Interfaces.User;
using SFX.Services.Service.Authentication;
using SFX.Web.Filters;
using SFX.Web.Helpers;
using SFX.Web.Modules;

namespace SFX.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IContainer ApplicationContainer { get; private set; }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {

            services.AddCors(options =>
            {
                options.AddPolicy("AllowSpecificOrigin",
                    config => config.WithOrigins("http://localhost:4200", "https://qpocweb.azurewebsites.net").AllowAnyMethod().AllowAnyHeader());
            });

            services.AddMvc(options =>
            {
                options.Filters.Add(typeof(ValidateModelAttribute));
            }).AddJsonOptions(options =>
            {
                options.SerializerSettings.DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Local;
            });

            var appSettingsSection = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);
            // configure jwt authentication
            
            services.AddDbContext<AppDbContext>(options => options.UseLazyLoadingProxies().UseSqlServer(Configuration["Data:DefaultConnection:ConnectionString"]));

            services.AddSwaggerDocumentation();
            services.AddSingleton<IAuthenticationService, AuthenticationService>();
            services.AddSingleton<IJwtTokenHelper,JwtTokenHelper>();

            services.AddJwtAuthentication(Configuration);
            var builder = new ContainerBuilder();
            builder.RegisterModule(new InjectionModule());
            builder.Populate(services);
            ApplicationContainer = builder.Build();
           
            return new AutofacServiceProvider(ApplicationContainer);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors("AllowSpecificOrigin");

            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseSwaggerDocumentation();
            app.UseMvc();
        }
    }
}
