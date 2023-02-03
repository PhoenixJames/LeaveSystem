using LeaveSystem.Models;

namespace LeaveSystem.IServices {

  public interface IEmployeeServices {

    Task<ApiResponse> EmployeeRegister (EmployeeRegisterModel model);
    
    Task<ServiceResponse<EmployeeViewModel>> GetAllEmployee();

  }

}
