using EFCoreWebApi.EF;
using EFCoreWebApi.Initializers;
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
            SetupDatabase(services);
            SetupScoped(services);
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

            PrepareCleanDatabase(context);
        }

        private void SetupDatabase(IServiceCollection services) {
            services.AddDbContext<ApplicationDbContext>((options) => {
                options.UseNpgsql(Configuration.GetConnectionString("PetDatabase"));
            });
        }

        private void SetupScoped(IServiceCollection services) {
            services.AddScoped<IDataInitializer, DataInitializer>();
        }

        private void PrepareCleanDatabase(ApplicationDbContext context) {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }

    }

}
