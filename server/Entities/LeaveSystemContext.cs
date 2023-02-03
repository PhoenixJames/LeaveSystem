using Microsoft.EntityFrameworkCore;
using System;
using System.IO; 
using System.Collections.Generic;

namespace LeaveSystem.Entities
{
    public class LeaveSystemContext : DbContext
    {



        public LeaveSystemContext(DbContextOptions<LeaveSystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employee { get; set; }

        public virtual DbSet<Leave> Leave { get; set; }

        public virtual DbSet<LeaveDetail> LeaveDetail { get; set; }

        public virtual DbSet<LeaveTypes> LeaveTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var serverVersion = new MySqlServerVersion(new Version(8, 0, 25));
                optionsBuilder.UseMySql("ConnectionStrings : DefaultConnection", serverVersion);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<LeaveTypes>().HasData(
                new LeaveTypes {
                    Id = 1,
                    Type = "Casual Leave",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                },
                new LeaveTypes {
                    Id = 2,
                    Type = "Medical Leave",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                },
                new LeaveTypes {
                    Id = 3,
                    Type = "Earned Leave",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                }
            );

        }

    }
}
