using dotNetApiWithRedisCacheApplication.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// builder.Services.AddControllers();
// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

builder.Services.AddHttpClient();
builder.Services.AddOutputCache().AddStackExchangeRedisOutputCache(a =>
{
    a.InstanceName = "paulApi";
    a.Configuration = "localhost:6379";
}  );
//沒用, 要加在AddOutputCache後面
//builder.Services.AddStackExchangeRedisCache(a => a.Configuration = "localhost:6379");

builder.Services.AddTransient<IWeatherService, OpenWeatherMapService>();

var app = builder.Build();

app.UseOutputCache();

app.UseHttpsRedirection();

app.MapGet("/weather", async (string city, IWeatherService weatherService) =>
    {
        var weather = await weatherService.GetWeatherForTwLocation36HrForecastAsync(city);
        return weather is null ? Results.NotFound() : Results.Ok(weather);
    }).CacheOutput(a=>a.Expire(TimeSpan.FromMinutes(5)))
    .WithName("GetWeatherForecast")
    .WithOpenApi();

// app.UseAuthorization();

// app.MapControllers();

app.Run();