using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreWithNorthWind.Contexts;
using DotNetCoreWithNorthWind.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DotNetCoreWithNorthWind
{
  public class Startup
  {
    private readonly IConfiguration _config;

    public Startup(IConfiguration config)
    {
      _config = config;
    }

    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMvc();
      services.AddDbContext<OrderContext>(options =>{ options.UseSqlServer(_config.GetConnectionString("DefaultConnection")); });
      services.AddDbContext<EmployeeContext>(options =>{ options.UseSqlServer(_config.GetConnectionString("DefaultConnection")); });
      services.AddDbContext<CustomerContext>(options =>{ options.UseSqlServer(_config.GetConnectionString("DefaultConnection")); });
      services.AddScoped<IOrderService, OrderService>();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env, OrderContext dbContext)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseStaticFiles();

      // 建立資料庫            
      dbContext.Database.EnsureCreated();
      app.UseMvcWithDefaultRoute();
    }
  }
}
