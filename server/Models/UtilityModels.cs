namespace LeaveSystem.Models {
  public class UtilityModels {
  }

  public class ValidatorModel {

    public bool Result { get; set; }
    
    public string Message { get; set; }

    public ValidatorModel(bool Result, string Message)
    {
      this.Result = Result;
      this.Message = Message;
    }

  }

}
