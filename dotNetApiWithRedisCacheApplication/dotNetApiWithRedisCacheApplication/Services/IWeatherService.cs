using dotNetApiWithRedisCacheApplication.Models;

namespace dotNetApiWithRedisCacheApplication.Services;

public interface IWeatherService
{
    Task<WeatherResponse?> GetWeatherForTwLocation36HrForecastAsync(string locationZhTw);
}