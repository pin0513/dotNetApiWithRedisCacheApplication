namespace dotNetApiWithRedisCacheApplication.Models;

public class ResultVm
{
    public string resource_id { get; set; }
    public FieldVm[] fields { get; set; }
}