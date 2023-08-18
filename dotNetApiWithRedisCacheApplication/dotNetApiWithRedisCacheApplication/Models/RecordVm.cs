using dotNetApiWithRedisCacheApplication.Models;

public class RecordVm
{
    public string datasetDescription { get; set; }
    public LocationVm[] location { get; set; }
}