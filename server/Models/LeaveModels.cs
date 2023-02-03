using Newtonsoft.Json;

namespace LeaveSystem.Models {
  public class LeaveModels {
  }

  public class LeaveApplyModel {
    [JsonProperty("leaveTypeId")]
    public long LeaveTypeId { get; set; }

    [JsonProperty("employeeId")]
    public long EmployeeId { get; set; }
    
    [JsonProperty("fromDate")]
    public DateTime FromDate { get; set; }

    [JsonProperty("toDate")]
    public DateTime ToDate { get; set; }

    [JsonProperty("duration")]
    public long Duration { get; set; }

  }

  public class LeaveViewModel {
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("leaveTypeId")]
    public long LeaveTypeId { get; set; }

    [JsonProperty("employeeId")]
    public long EmployeeId { get; set; }
    
    [JsonProperty("fromDate")]
    public DateTime FromDate { get; set; }

    [JsonProperty("toDate")]
    public DateTime ToDate { get; set; }

    [JsonProperty("duration")]
    public long Duration { get; set; }

  }
}
