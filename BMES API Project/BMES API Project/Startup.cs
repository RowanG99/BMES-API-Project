using BMES_API_Project.Database;
using BMES_API_Project.Repository;
using BMES_API_Project.Repository.Implementations;
using BMES_API_Project.Services;
using BMES_API_Project.Services.Implementations;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace BMES_API_Project
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
            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(name: "v1", new OpenApiInfo { Title = "Building Materials E-Store", Version = "v1" });
            });

            services.AddDbContext<dbContext>(optionsAction: options => options.UseSqlite(Configuration["Data:BMESAPIProject:ConnectionString"]));
            services.AddTransient<iBrandRepo, BrandRepo>();
            services.AddTransient<iCategoryRepo, CategoryRepo>();
            services.AddTransient<iProductRepo, ProductRepo>();

            services.AddTransient<iBrandService, BrandService>();
            services.AddTransient<iCategoryService, CatergoryService>();
            services.AddTransient<iProductService, ProductService>();
            services.AddTransient<iCatalogueService, CatalogueService>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint(url: "/swagger/v1/swagger.json", name: "Building Materials E-Store V1");
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
