using Microsoft.AspNetCore.Mvc;
using LeaveSystem.IServices;
using LeaveSystem.Models;

namespace LeaveSystem.Controllers {

  [Route("api/[controller]")]
  [ApiController]
  public class LeaveController : ControllerBase {

    private readonly IUnitOfWork _unitOfWork;

    public LeaveController(IUnitOfWork unitOfWork){
      _unitOfWork = unitOfWork;
    }

    [HttpPost("[action]")]
    public async Task<ApiResponse> ApplyLeave([FromBody] LeaveApplyModel model) {

      var result = await _unitOfWork.LeaveServices.ApplyLeave(model);
      return result;

    } 

    [HttpGet("[action]")]
    public async Task<ServiceResponse<List<LeaveViewModel>>> GetAllLeave() {

      var result = await _unitOfWork.LeaveServices.GetAllLeave();
      return result;

    } 

    [HttpGet("[action]")]
    public async Task<ServiceResponse<List<LeaveDetailViewModel>>> GetLeaveDetailByEmpId(long id) {

      var result = await _unitOfWork.LeaveServices.GetLeaveDetailByEmpId(id);
      return result;

    } 

  }

}
