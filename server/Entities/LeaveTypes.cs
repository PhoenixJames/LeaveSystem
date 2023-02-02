using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveSystem.Entities {
  [Table("leavetypes")]
  public class LeaveTypes {
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("Type")]
    public long Type { get; set; }
    
    [Column("createddate")]
    public DateTime CreatedDate {get; set;}

    [Column("updateddate")]
    public DateTime UpdatedDate {get; set;}

  }

}

