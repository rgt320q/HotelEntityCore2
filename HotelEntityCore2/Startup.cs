﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using HotelEntityCore2.Data.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;

namespace HotelEntityCore2
{
    public class Startup
    {
        public IConfiguration Configuration;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DataConnection"));
                options.EnableSensitiveDataLogging(true);
            });
            //services.AddDbContext<UserContext>(options => options.UseSqlServer(Configuration.GetConnectionString("UserConnection")));
            //services.AddTransient<ICourseRepository, EfCourseRepository>();
            //services.AddTransient<IUserRepository, UserRepository>();
            //services.AddTransient<IInstructorRepository, EfInstructorRepository>();
            //services.AddTransient<IGenericRepository<Contact>, GenericRepository<Contact>>();
            //services.AddTransient<IGenericRepository<Address>, GenericRepository<Address>>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //SeedDatabase.Seed(dataContext);
                //SeedDatabase.Seed(UserContext);
            }

            app.UseDeveloperExceptionPage();

            app.UseStatusCodePages();

            //wwwroot
            app.UseStaticFiles();

            app.UseStaticFiles();

            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"node_modules")),
                RequestPath = new PathString("/vendor")
            });

            app.UseMvcWithDefaultRoute();
        }
    }
}
