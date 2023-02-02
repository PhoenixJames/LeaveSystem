using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveSystem.Entities {
  [Table("employee")]
  public class Employee {
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("name")]
    public string Name { get; set; }
    
    [Column("dob")]
    public DateTime DOB { get; set; }

    [Column("position")]
    public string Position { get; set; }

    [Column("createddate")]
    public DateTime CreatedDate {get; set;}

    [Column("updateddate")]
    public DateTime UpdatedDate {get; set;}
  }

}

