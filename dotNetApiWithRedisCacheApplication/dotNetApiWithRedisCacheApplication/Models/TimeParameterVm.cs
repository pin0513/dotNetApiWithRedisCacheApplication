namespace dotNetApiWithRedisCacheApplication.Models;

public class TimeParameterVm
{
    public string startTime { get; set; }
    public string endTime { get; set; }
    public Dictionary<string, string> parameter{ get; set; }
}