using Basket.API.Repositories;

namespace Basket.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        
        //Add Dependencies/Services in this section
        public void RegisterServices(IServiceCollection Services)
        {
            Services.AddControllers();
            Services.AddEndpointsApiExplorer();
            Services.AddSwaggerGen();

            Services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = Configuration.GetValue<string>("CacheSettings:ConnectionString");
            });
            Services.AddScoped<IBasketRepository, BasketRepository>();

        }

        //Add middleware in this section
        public void SetMiddleWare(WebApplication app, IWebHostEnvironment env)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
