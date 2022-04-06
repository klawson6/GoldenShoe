using GoldenShoeAPI.Context;
using GoldenShoeAPI.DTO;
using GoldenShoeAPI.Factories;
using GoldenShoeAPI.Interfaces;
using GoldenShoeAPI.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace GoldenShoeAPI
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
				c.SwaggerDoc("v1", new OpenApiInfo { Title = "GoldenShoeAPI", Version = "v1" });
			});
			services.AddDbContext<GoldenShoeContext>(options => options.UseSqlite(@"Data Source=GoldenShoe.db"));
            services.AddTransient<IShoeRepository, ShoeRepository>();
			services.AddTransient<IShoeColourRepository, ShoeColourRepository>();
			services.AddTransient<IShoeColourSizeRepository, ShoeColourSizeRepository>();
			services.AddTransient<IBrandRepository, BrandRepository>();
			services.AddTransient<IColourRepository, ColourRepository>();
			services.AddTransient<IShoeSizeRepository, ShoeSizeRepository>();
			services.AddTransient<IStoreRepository, StoreRepository>();
			services.AddTransient<IStyleRepository, StyleRepository>();
			services.AddTransient<IShoeColourSizeStockRepository, ShoeColourSizeStockRepository>();
			services.AddTransient<IStyleRepository, StyleRepository>();
			services.AddTransient<IShoeDTOFactory, ShoeDTOFactory>();
			services.AddTransient<DbManagement>();
			services.AddTransient<IShoeDTO, ShoeDTO>();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseSwagger();
				app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "GoldenShoeAPI v1"));
			}

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
