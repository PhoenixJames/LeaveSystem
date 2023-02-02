using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveSystem.Entities {
  [Table("leave")]
  public class Leave {
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("leaveTypeId")]
    public long LeaveTypeId { get; set; }
    
    [Column("employeeId")]
    public long EmployeeId { get; set; }
    
    [Column("fromdate")]
    public DateTime FromDate { get; set; }

    [Column("todate")]
    public DateTime ToDate { get; set; }

    [Column("duration")]
    public long Duration { get; set; }

    [Column("createddate")]
    public DateTime CreatedDate {get; set;}

    [Column("updateddate")]
    public DateTime UpdatedDate {get; set;}
  }

}

