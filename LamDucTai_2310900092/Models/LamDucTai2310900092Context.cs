using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LamDucTai_2310900092.Models;

public partial class LamDucTai2310900092Context : DbContext
{
    public LamDucTai2310900092Context()
    {
    }

    public LamDucTai2310900092Context(DbContextOptions<LamDucTai2310900092Context> options)
        : base(options)
    {
    }

    public virtual DbSet<LdtEmployee> LdtEmployees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-DV4I0GVH\\MSSQLSERVER01;Database=LamDucTai_2310900092;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LdtEmployee>(entity =>
        {
            entity.HasKey(e => e.LdtEmpId).HasName("PK__LdtEmplo__7F9A849FA3E5584E");

            entity.ToTable("LdtEmployee");

            entity.Property(e => e.LdtEmpId)
                .ValueGeneratedNever()
                .HasColumnName("ldtEmpId");
            entity.Property(e => e.LdtEmpLevel)
                .HasMaxLength(50)
                .HasColumnName("ldtEmpLevel");
            entity.Property(e => e.LdtEmpName)
                .HasMaxLength(100)
                .HasColumnName("ldtEmpName");
            entity.Property(e => e.LdtEmpStartDate).HasColumnName("ldtEmpStartDate");
            entity.Property(e => e.LdtEmpStatus).HasColumnName("ldtEmpStatus");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
