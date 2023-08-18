namespace dotNetApiWithRedisCacheApplication.Models;

public class WeatherResponse
{
    public string success { get; set; }
    public ResultVm result { get; set; }
    public RecordVm records { get; set; }
}