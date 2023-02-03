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

    public UnitOfWork(LeaveSystemContext context) {
      _context = context;
    }


    public IEmployeeServices EmployeeServices =>
      new EmployeeServices(_context);

    public ILeaveServices LeaveServices =>
      new LeaveServices(_context);
  }


}
