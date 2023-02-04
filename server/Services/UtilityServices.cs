using System.Data;
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
      if (model.FromDate.Date < DateTime.Now.Date) {
        return new ValidatorModel(false, "Cannot apply the past days.");
      }
      var appliedDates = _context.LeaveDetail
        .Where(x => x.EmployeeId == model.EmployeeId && x.Date.Date >= model.FromDate.Date)
        .ToList();
      if (appliedDates.Count > 0) {
        return new ValidatorModel(false, "The dates are already applied.");
      }
      return new ValidatorModel(true, "Valid");
    }

  }

}
