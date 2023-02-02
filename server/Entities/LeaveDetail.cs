using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveSystem.Entities {
  [Table("leavedetail")]
  public class LeaveDetail {
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("leaveTypeId")]
    public long LeaveTypeId { get; set; }
    
    [Column("employeeId")]
    public long EmployeeId { get; set; }
    
    [Column("date")]
    public DateTime Date { get; set; }

    [Column("createddate")]
    public DateTime CreatedDate {get; set;}

    [Column("updateddate")]
    public DateTime UpdatedDate {get; set;}
  }

}

