using LeaveSystem.Models;

namespace LeaveSystem.IServices {

  public interface IUtilityServices {
    
    List<DateTime> EachDay(DateTime from, DateTime to);
    
    ValidatorModel IsValidLeave (LeaveApplyModel model);
  }

}
