using System.Collections.Generic;
using EFCoreWebApi.EF;
using EFCoreWebApi.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EFCoreWebApi {

    public class Startup {

        /*------------------------ FIELDS REGION ------------------------*/
        public IConfiguration Configuration { get; }

        /*------------------------ METHODS REGION ------------------------*/
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            services.AddControllers();
            services.AddDbContext<ApplicationDbContext>((options) => {
                options.UseNpgsql(Configuration.GetValue<string>("ConnectionStrings"));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,
                              ApplicationDbContext context) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

            SeedData(context);
        }

        private void SeedData(ApplicationDbContext context) {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            Owner owner = new Owner("Kamil", "Kowalewski");
            Pet dog = new Pet("Dog", owner);
            Pet cat = new Pet("Cat", owner);
            owner.AddPetsToOwner(new List<Pet> {dog, cat});
            context.Pets.Add(dog);
            context.Owners.Add(owner);
            context.SaveChanges();
        }

    }

}
