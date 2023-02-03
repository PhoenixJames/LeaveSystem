using Newtonsoft.Json;

namespace LeaveSystem.Models {
  public class LeaveTypesModels {
  }

  public class LeaveTypesModel {

    [JsonProperty("Type")]
    public string type { get; set; }
    
  }

  public class LeaveTypesViewModel {
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

  }
}
