using LeaveSystem.Models;

namespace LeaveSystem.IServices {

  public interface ILeaveServices {

    Task<ApiResponse> ApplyLeave (LeaveApplyModel model);
    
    Task<ServiceResponse<List<LeaveViewModel>>> GetAllLeave();

    Task<ServiceResponse<List<LeaveDetailViewModel>>> GetLeaveDetailByEmpId(long id);
  }

}
