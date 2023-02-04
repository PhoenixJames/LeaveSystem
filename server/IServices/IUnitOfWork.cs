namespace LeaveSystem.IServices {
  public interface IUnitOfWork {
    
    IEmployeeServices EmployeeServices { get;}

    ILeaveServices LeaveServices { get; }

    IUtilityServices UtilityServices { get; }

  }
}
