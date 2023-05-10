using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFDemo.Models;

public partial class EmpDbContext : DbContext
{
    public EmpDbContext()
    {
    }

    public EmpDbContext(DbContextOptions<EmpDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=ANAMIKA\\SQLSERVER;Initial Catalog=EmpDb;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3213E83FC39AACBA");

            entity.ToTable("Employee");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BasicSalary).HasColumnName("Basic_salary");
            entity.Property(e => e.ChargersPerDay).HasColumnName("Chargers_PerDay");
            entity.Property(e => e.ContractBasis)
                .HasColumnType("datetime")
                .HasColumnName("Contract_Basis");
            entity.Property(e => e.Da).HasColumnName("DA");
            entity.Property(e => e.DurationInDays).HasColumnName("Duration_In_Days");
            entity.Property(e => e.EmpType).HasColumnName("emp_type");
            entity.Property(e => e.Hra).HasColumnName("HRA");
            entity.Property(e => e.JoiningDate)
                .HasColumnType("datetime")
                .HasColumnName("Joining_Date");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.OnContractFinalSalary).HasColumnName("OnContract_FinalSalary");
            entity.Property(e => e.Pf).HasColumnName("PF");
            entity.Property(e => e.ReportingManager)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Reporting_Manager");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
