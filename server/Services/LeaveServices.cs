using Microsoft.EntityFrameworkCore;
using LeaveSystem.Entities;
using LeaveSystem.IServices;
using LeaveSystem.Models;

namespace LeaveSystem.Services {

  public class LeaveServices : ILeaveServices {

    private readonly LeaveSystemContext _context;

    public LeaveServices(LeaveSystemContext context) {
      
      _context = context;
  
    }
    public IEnumerable<DateTime> EachDay(DateTime from, DateTime to)
    {
      for(var day = from.Date; day.Date <= to.Date; day = day.AddDays(1))
        yield return day;
    }
    
    public async Task<ApiResponse> ApplyLeave (LeaveApplyModel model) {
      
      try {
        Leave NewLeave = new () {
          LeaveTypeId = model.LeaveTypeId,
          EmployeeId = model.EmployeeId,
          FromDate = model.FromDate,
          ToDate = model.ToDate,
          Duration = model.Duration,
          CreatedDate = DateTime.Now
        };
        await _context.AddAsync(NewLeave);
        await _context.SaveChangesAsync();

        foreach (DateTime day in EachDay(model.FromDate, model.ToDate)) {
          if ((day.DayOfWeek != DayOfWeek.Saturday) && (day.DayOfWeek != DayOfWeek.Sunday))
          {
            LeaveDetail NewLeaveDetail = new () {
              LeaveTypeId = model.LeaveTypeId,
              EmployeeId = model.EmployeeId,
              Date = day,
              CreatedDate = DateTime.Now
            };

            await _context.AddAsync(NewLeaveDetail);
          }

          await _context.SaveChangesAsync();
        }

        return new ApiResponse("Leave Apply Successful", 200);
        
      } catch (InvalidCastException e) {
        return new ApiResponse(e.Message, 400);
      }
    }

    public async Task<ServiceResponse<List<LeaveViewModel>>> GetAllLeave() {
      List<LeaveViewModel> result;
      try {

        result = await _context
          .Leave
          .Select(x => new LeaveViewModel {
            Id = x.Id,
            LeaveTypeId = x.LeaveTypeId,
            EmployeeId = x.EmployeeId,
            FromDate = x.FromDate,
            ToDate = x.ToDate,
            Duration = x.Duration
          })
          .ToListAsync();
        
        return new ServiceResponse<List<LeaveViewModel>>(200, "Success", result);

      } catch (InvalidCastException e) {

        return new ServiceResponse<List<LeaveViewModel>>(400, e.Message, null);

      }

    }
    
  }

}
