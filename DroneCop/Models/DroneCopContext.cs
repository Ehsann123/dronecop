using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DroneCop.Models;

public partial class DroneCopContext : DbContext
{
    public DroneCopContext()
    {
    }

    public DroneCopContext(DbContextOptions<DroneCopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Criminal> Criminals { get; set; }

    public virtual DbSet<Image> Images { get; set; }

    public virtual DbSet<Policeman> Policemen { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-5I8QR22;Initial Catalog=drone_cop;Integrated Security=True;TrustServerCertificate=True ; ");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Criminal>(entity =>
        {
            entity.HasKey(e => e.CriminalId).HasName("PK__Criminal__2A65873C75735CBA");

            entity.ToTable("Criminal");

            entity.Property(e => e.CriminalId)
                .ValueGeneratedNever()
                .HasColumnName("Criminal_ID");
            entity.Property(e => e.Cnic)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CNIC");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("Date_Created");
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Height).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.IsDeleted).HasColumnName("Is_Deleted");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Image>(entity =>
        {
            entity.HasKey(e => e.ImgId).HasName("PK__Image__05B3F7FBC5D3E49E");

            entity.Property(e => e.ImgId)
                .ValueGeneratedNever()
                .HasColumnName("Img_ID");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("Date_Created");
            entity.Property(e => e.ImgExtension)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Img_Extension");
            entity.Property(e => e.ImgPath)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Img_Path");
            entity.Property(e => e.IsDeleted).HasColumnName("Is_Deleted");
        });

        modelBuilder.Entity<Policeman>(entity =>
        {
            entity.HasKey(e => e.PoliceId).HasName("PK__Policema__D49CF8124EB309B7");

            entity.ToTable("Policeman");

            entity.Property(e => e.PoliceId)
                .ValueGeneratedNever()
                .HasColumnName("Police_ID");
            entity.Property(e => e.Cnic)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CNIC");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("Date_Created");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("F_Name");
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IsActive).HasColumnName("Is_Active");
            entity.Property(e => e.IsDeleted).HasColumnName("Is_Deleted");
            entity.Property(e => e.JoiningDate)
                .HasColumnType("date")
                .HasColumnName("Joining_date");
            entity.Property(e => e.LName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("L_Name");
            entity.Property(e => e.Rank)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__206D91903D1344C3");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("User_ID");
            entity.Property(e => e.Cnic)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CNIC");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("Date_Created");
            entity.Property(e => e.DesignationId).HasColumnName("Designation_ID");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.IsActive).HasColumnName("Is_Active");
            entity.Property(e => e.IsDeleted).HasColumnName("Is_Deleted");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
