using Microsoft.AspNetCore.Mvc;
using LeaveSystem.IServices;
using LeaveSystem.Models;

namespace LeaveSystem.Controllers {

  [Route("api/[controller]")]
  [ApiController]
  public class EmployeeController : ControllerBase {

    private readonly IUnitOfWork _unitOfWork;

    public EmployeeController(IUnitOfWork unitOfWork){
      _unitOfWork = unitOfWork;
    }

    [HttpPost("[action]")]
    public async Task<ApiResponse> EmployeeRegister([FromBody] EmployeeRegisterModel model) {

      var result = await _unitOfWork.EmployeeServices.EmployeeRegister(model);
      return result;

    } 

    [HttpGet("[action]")]
    public async Task<ServiceResponse<List<EmployeeViewModel>>> GetAllEmployee() {

      var result = await _unitOfWork.EmployeeServices.GetAllEmployee();
      return result;

    } 

    [HttpGet("[action]")]
    public string GetAll() {

      return "Hello world";

    } 
  }

}
