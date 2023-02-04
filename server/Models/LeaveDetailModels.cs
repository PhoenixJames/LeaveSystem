using Newtonsoft.Json;

namespace LeaveSystem.Models {
  public class LeaveDetailModels {
  }


  public class LeaveDetailViewModel {
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("leaveTypeId")]
    public long LeaveTypeId { get; set; }

    [JsonProperty("employeeId")]
    public long EmployeeId { get; set; }
    
    [JsonProperty("date")]
    public DateTime Date { get; set; }

  }
}
