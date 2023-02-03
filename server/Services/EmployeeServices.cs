using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using LeaveSystem.Entities;
using LeaveSystem.IServices;
using LeaveSystem.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveSystem.Services {

  public class EmployeeServices : IEmployeeServices {

    private readonly LeaveSystemContext _context;

    public EmployeeServices(LeaveSystemContext context) {
      
      _context = context;
  
    }
    
    public async Task<ApiResponse> EmployeeRegister (EmployeeRegisterModel model) {
      
      return new ApiResponse("success", 200);

    }

    public async Task<ServiceResponse<EmployeeViewModel>> GetAllEmployee() {
      var result = new EmployeeViewModel{
        Id = 1,
        Name = "Ko Ko",
        DOB = DateTime.Now,
        Position = "Manager"
      };
      return new ServiceResponse<EmployeeViewModel>(200, "success", result);

    }


  }

}
