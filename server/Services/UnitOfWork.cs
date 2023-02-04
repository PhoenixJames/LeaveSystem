using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using LeaveSystem.Entities;
using LeaveSystem.IServices;
using LeaveSystem.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LeaveSystem.Services {

  public class UnitOfWork : IUnitOfWork {
  
    private readonly LeaveSystemContext _context;

    private readonly IUtilityServices _util;
    
    public UnitOfWork(LeaveSystemContext context,
                      IUtilityServices util
    ) {
      _context = context;
      _util = util;
    }


    public IEmployeeServices EmployeeServices =>
      new EmployeeServices(_context);

    public ILeaveServices LeaveServices =>
      new LeaveServices(_context, _util);
    
    public IUtilityServices UtilityServices =>
      new UtilityServices(_context);

  }


}
