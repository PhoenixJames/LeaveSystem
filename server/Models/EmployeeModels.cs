using Newtonsoft.Json;

namespace LeaveSystem.Models {
  public class EmployeeModels {
  }

  public class EmployeeRegisterModel {
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("dob")]
    public DateTime DOB { get; set; }

    [JsonProperty("position")]
    public string Position { get; set; }
  }

  public class EmployeeViewModel {
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("dob")]
    public DateTime DOB { get; set; }

    [JsonProperty("position")]
    public string Position { get; set; }
  }

}
