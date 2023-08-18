namespace dotNetApiWithRedisCacheApplication.Models;

public class LocationVm
{
    public string locationName { get; set; }
    public WeatherElementVm[] weatherElement { get; set; }
}