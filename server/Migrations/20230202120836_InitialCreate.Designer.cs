// <auto-generated />
using System;
using LeaveSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LeaveSystem.Migrations
{
    [DbContext(typeof(LeaveSystemContext))]
    [Migration("20230202120836_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LeaveSystem.Entities.Employee", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("createddate");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("dob");

                    b.Property<string>("Name")
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.Property<string>("Position")
                        .HasColumnType("longtext")
                        .HasColumnName("position");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updateddate");

                    b.HasKey("Id");

                    b.ToTable("employee");
                });

            modelBuilder.Entity("LeaveSystem.Entities.Leave", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("createddate");

                    b.Property<long>("Duration")
                        .HasColumnType("bigint")
                        .HasColumnName("duration");

                    b.Property<long>("EmployeeId")
                        .HasColumnType("bigint")
                        .HasColumnName("employeeId");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("fromdate");

                    b.Property<long>("LeaveTypeId")
                        .HasColumnType("bigint")
                        .HasColumnName("leaveTypeId");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("todate");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updateddate");

                    b.HasKey("Id");

                    b.ToTable("leave");
                });

            modelBuilder.Entity("LeaveSystem.Entities.LeaveDetail", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("createddate");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("date");

                    b.Property<long>("EmployeeId")
                        .HasColumnType("bigint")
                        .HasColumnName("employeeId");

                    b.Property<long>("LeaveTypeId")
                        .HasColumnType("bigint")
                        .HasColumnName("leaveTypeId");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updateddate");

                    b.HasKey("Id");

                    b.ToTable("leavedetail");
                });

            modelBuilder.Entity("LeaveSystem.Entities.LeaveTypes", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("createddate");

                    b.Property<long>("Type")
                        .HasColumnType("bigint")
                        .HasColumnName("Type");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updateddate");

                    b.HasKey("Id");

                    b.ToTable("leavetypes");
                });
#pragma warning restore 612, 618
        }
    }
}
