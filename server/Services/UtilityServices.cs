using Microsoft.EntityFrameworkCore;
using LeaveSystem.Entities;
using LeaveSystem.IServices;
using LeaveSystem.Models;

namespace LeaveSystem.Services {

  public class UtilityServices : IUtilityServices {

    private readonly LeaveSystemContext _context;

    public UtilityServices(LeaveSystemContext context) {
      
      _context = context;
  
    }
    public List<DateTime> EachDay(DateTime from, DateTime to) {
      List<DateTime> result = new List<DateTime>();
      for(var day = from.Date; day.Date <= to.Date; day = day.AddDays(1))
        result.Add(day);

      return result;
    }

    public ValidatorModel IsValidLeave (LeaveApplyModel model) {
      
      return new ValidatorModel(false, "Invalid");
    }

  }

}
