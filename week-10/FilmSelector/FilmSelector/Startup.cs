using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmSelector.Entities;
using FilmSelector.Repositories;
using FilmSelector.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace FilmSelector
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<SelectorContext>(options => options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=FilmSelector;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));
            services.AddScoped<FilmRepository>();
            services.AddScoped<SeriesRepository>();
            services.AddScoped<UserRepository>();
            services.AddScoped<ProgramService>();
            services.AddScoped<UserService>();
            services.AddScoped<LoginService>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMvc();
        }
    }
}
