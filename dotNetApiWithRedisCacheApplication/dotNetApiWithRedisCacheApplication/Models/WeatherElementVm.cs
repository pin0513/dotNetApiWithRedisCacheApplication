using dotNetApiWithRedisCacheApplication.Models;

public class WeatherElementVm
{
    public string elementName { get; set; }
    public TimeParameterVm[] time { get; set; }
}