using AddSingleton_Transient_Scoped.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AddSingleton_Transient_Scoped
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

            //Какво казва това регистриране(обвързване) на интерфейса IEmployeeRepository с класа MockEmployeeRepository -> Когато някой (Controller примерно или View) ти поиска в ctor-а си интерфейса IEmployeeRepository ти му дай всето това класа MockEmployeeRepository.
            //Ако регистрирам AddSingleton<IEmployeeRepository, MockEmployeeRepository>(); където извикам в ctor-a IEmployeeRepository, ще ми се прави инстанция на MockEmployeeRepository. Ако регистрирам AddSingleton<IEmployeeRepository, JoroRepository>(); където извикам в ctor-a IEmployeeRepository, ще ми се прави инстанция на JoroRepository т.е. мога да направя няколко класа които да наследяват IEmployeeRepository и тук само да ги сменям
            services.AddSingleton<IEmployeeRepository, MockEmployeeRepository>();
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
