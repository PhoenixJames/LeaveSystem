using Microsoft.EntityFrameworkCore;
using LeaveSystem.Entities;
using LeaveSystem.IServices;
using LeaveSystem.Models;

namespace LeaveSystem.Services {

  public class EmployeeServices : IEmployeeServices {

    private readonly LeaveSystemContext _context;

    public EmployeeServices(LeaveSystemContext context) {
      
      _context = context;
  
    }
    
    public async Task<ApiResponse> EmployeeRegister (EmployeeRegisterModel model) {
      
      try {
        Employee NewEmployee = new () {
          Name = model.Name,
          DOB = model.DOB,
          Position = model.Position,
          CreatedDate = DateTime.Now
        };
        await _context.AddAsync(NewEmployee);
        await _context.SaveChangesAsync();

        return new ApiResponse("Employee Create Successful", 200);
        
      } catch (InvalidCastException e) {
        return new ApiResponse(e.Message, 400);
      }
    }

    public async Task<ServiceResponse<List<EmployeeViewModel>>> GetAllEmployee() {
      List<EmployeeViewModel> result;
      try {

        result = await _context
          .Employee
          .Select(x => new EmployeeViewModel {
            Id = x.Id,
            Name = x.Name,
            DOB = x.DOB,
            Position = x.Position
          })
          .ToListAsync();
        
        return new ServiceResponse<List<EmployeeViewModel>>(200, "Success", result);

      } catch (InvalidCastException e) {

        return new ServiceResponse<List<EmployeeViewModel>>(400, e.Message, null);

      }

    }
    
  }

}
