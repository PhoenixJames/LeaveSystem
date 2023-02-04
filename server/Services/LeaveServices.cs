using Microsoft.EntityFrameworkCore;
using LeaveSystem.Entities;
using LeaveSystem.IServices;
using LeaveSystem.Models;

namespace LeaveSystem.Services {

  public class LeaveServices : ILeaveServices {

    private readonly LeaveSystemContext _context;

    private readonly IUtilityServices _util;

    public LeaveServices(LeaveSystemContext context, IUtilityServices util) {
      
      _context = context;
      _util = util;
  
    }
    
    public async Task<ApiResponse> ApplyLeave (LeaveApplyModel model) {
      
      try {
        var isValid = _util.IsValidLeave(model);
        if(!isValid.Result) {
          return new ApiResponse(isValid.Message, 400);
        }
        Leave NewLeave = new () {
          LeaveTypeId = model.LeaveTypeId,
          EmployeeId = model.EmployeeId,
          FromDate = model.FromDate.Date,
          ToDate = model.ToDate.Date,
          Duration = model.Duration,
          CreatedDate = DateTime.Now
        };
        await _context.AddAsync(NewLeave);
        await _context.SaveChangesAsync();

        foreach (DateTime day in _util.EachDay(model.FromDate, model.ToDate)) {
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
    
    public async Task<ServiceResponse<List<LeaveDetailViewModel>>> GetLeaveDetailByEmpId(long id) {
      List<LeaveDetailViewModel> result;
      try {

        result = await _context
          .LeaveDetail
          .Select(x => new LeaveDetailViewModel {
            Id = x.Id,
            LeaveTypeId = x.LeaveTypeId,
            EmployeeId = x.EmployeeId,
            Date = x.Date
          })
          .Where(x => x.EmployeeId == id)
          .ToListAsync();
        
        return new ServiceResponse<List<LeaveDetailViewModel>>(200, "Success", result);

      } catch (InvalidCastException e) {

        return new ServiceResponse<List<LeaveDetailViewModel>>(400, e.Message, null);

      }

    }

  }

}
