using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Proyecto_BASES_POO_2021.ProjectContext
{
    public partial class PROJECT_BD_POOContext : DbContext
    {
        public PROJECT_BD_POOContext()
        {
        }

        public PROJECT_BD_POOContext(DbContextOptions<PROJECT_BD_POOContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Cabin> Cabins { get; set; }
        public virtual DbSet<ChronicDisease> ChronicDiseases { get; set; }
        public virtual DbSet<CitizenForm> CitizenForms { get; set; }
        public virtual DbSet<Institution> Institutions { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<SessionU> SessionUs { get; set; }
        public virtual DbSet<SideEffect> SideEffects { get; set; }
        public virtual DbSet<TypeEmployee> TypeEmployees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=PROJECT_BD_POO;Trusted_connection=True; ");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AI");

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.HasKey(e => e.IdAppontiment)
                    .HasName("PK__APPOINTM__DC555EAA21898D07");

                entity.ToTable("APPOINTMENT");

                entity.Property(e => e.IdAppontiment).HasColumnName("id_appontiment");

                entity.Property(e => e.AppointmentAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("appointment_address");

                entity.Property(e => e.AppointmentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("appointment_date");

                entity.Property(e => e.DuiC)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dui_c");

                entity.Property(e => e.IdCabin).HasColumnName("id_cabin");

                entity.Property(e => e.WaitingTime)
                    .HasColumnType("datetime")
                    .HasColumnName("waiting_time");

                entity.HasOne(d => d.DuiCNavigation)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.DuiC)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__APPOINTME__dui_c__4CA06362");

                entity.HasOne(d => d.IdCabinNavigation)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.IdCabin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__APPOINTME__id_ca__4D94879B");
            });

            modelBuilder.Entity<Cabin>(entity =>
            {
                entity.HasKey(e => e.IdCabin)
                    .HasName("PK__CABIN__CFA1AA9ABD6460A9");

                entity.ToTable("CABIN");

                entity.Property(e => e.IdCabin).HasColumnName("id_cabin");

                entity.Property(e => e.CabinAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cabin_address");

                entity.Property(e => e.CabinEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cabin_email");

                entity.Property(e => e.IdManager).HasColumnName("id_manager");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phoneNumber");

                entity.HasOne(d => d.IdManagerNavigation)
                    .WithMany(p => p.Cabins)
                    .HasForeignKey(d => d.IdManager)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CABIN__id_manage__46E78A0C");
            });

            modelBuilder.Entity<ChronicDisease>(entity =>
            {
                entity.HasKey(e => e.IdCronicDisease)
                    .HasName("PK__CHRONIC___DB6169DF88D26524");

                entity.ToTable("CHRONIC_DISEASE");

                entity.Property(e => e.IdCronicDisease).HasColumnName("id_cronic_disease");

                entity.Property(e => e.DiseaseName)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("disease_name");

                entity.Property(e => e.DuiC)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dui_c");

                entity.HasOne(d => d.DuiCNavigation)
                    .WithMany(p => p.ChronicDiseases)
                    .HasForeignKey(d => d.DuiC)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CHRONIC_D__dui_c__4BAC3F29");
            });

            modelBuilder.Entity<CitizenForm>(entity =>
            {
                entity.HasKey(e => e.DuiC)
                    .HasName("PK__CITIZEN___86F4ECD7D9D34516");

                entity.ToTable("CITIZEN_FORM");

                entity.Property(e => e.DuiC)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dui_c");

                entity.Property(e => e.CitizenAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("citizen_address");

                entity.Property(e => e.CitizenEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("citizen_email");

                entity.Property(e => e.CitizenName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("citizen_name");

                entity.Property(e => e.IdInstitution).HasColumnName("id_institution");

                entity.Property(e => e.PriorityGroup).HasColumnName("priority_group");

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("telephone");

                entity.Property(e => e.VaccineDate)
                    .HasColumnType("datetime")
                    .HasColumnName("vaccine_date");

                entity.HasOne(d => d.IdInstitutionNavigation)
                    .WithMany(p => p.CitizenForms)
                    .HasForeignKey(d => d.IdInstitution)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CITIZEN_F__id_in__49C3F6B7");
            });

            modelBuilder.Entity<Institution>(entity =>
            {
                entity.HasKey(e => e.IdInstitution)
                    .HasName("PK__INSTITUT__512A185C1788E608");

                entity.ToTable("INSTITUTION");

                entity.Property(e => e.IdInstitution).HasColumnName("id_institution");

                entity.Property(e => e.InstitutionName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("institution_name");
            });

            modelBuilder.Entity<Manager>(entity =>
            {
                entity.HasKey(e => e.IdManager)
                    .HasName("PK__MANAGER__7F9D5D00D2244DF0");

                entity.ToTable("MANAGER");

                entity.Property(e => e.IdManager).HasColumnName("id_manager");

                entity.Property(e => e.IdTypeEmployee).HasColumnName("id_type_employee");

                entity.Property(e => e.InstitutionalEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("institutional_email");

                entity.Property(e => e.ManagerAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("manager_address");

                entity.Property(e => e.ManagerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("manager_name");

                entity.Property(e => e.Psw)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("psw");

                entity.Property(e => e.UserM)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_m");

                entity.HasOne(d => d.IdTypeEmployeeNavigation)
                    .WithMany(p => p.Managers)
                    .HasForeignKey(d => d.IdTypeEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MANAGER__id_type__45F365D3");
            });

            modelBuilder.Entity<SessionU>(entity =>
            {
                entity.HasKey(e => e.IdSession)
                    .HasName("PK__SESSION___A9E494D0EDE2F973");

                entity.ToTable("SESSION_U");

                entity.Property(e => e.IdSession).HasColumnName("id_session");

                entity.Property(e => e.IdCabin).HasColumnName("id_cabin");

                entity.Property(e => e.IdManager).HasColumnName("id_manager");

                entity.Property(e => e.SessionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("session_date");

                entity.HasOne(d => d.IdCabinNavigation)
                    .WithMany(p => p.SessionUs)
                    .HasForeignKey(d => d.IdCabin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SESSION_U__id_ca__48CFD27E");

                entity.HasOne(d => d.IdManagerNavigation)
                    .WithMany(p => p.SessionUs)
                    .HasForeignKey(d => d.IdManager)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SESSION_U__id_ma__47DBAE45");
            });

            modelBuilder.Entity<SideEffect>(entity =>
            {
                entity.HasKey(e => e.IdSideEffects)
                    .HasName("PK__SIDE_EFF__6772C9E379D5F2BD");

                entity.ToTable("SIDE_EFFECTS");

                entity.Property(e => e.IdSideEffects).HasColumnName("id_side_effects");

                entity.Property(e => e.DuiC)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dui_c");

                entity.Property(e => e.SideEffectsName)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("side_effects_name");

                entity.HasOne(d => d.DuiCNavigation)
                    .WithMany(p => p.SideEffects)
                    .HasForeignKey(d => d.DuiC)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SIDE_EFFE__dui_c__4AB81AF0");
            });

            modelBuilder.Entity<TypeEmployee>(entity =>
            {
                entity.HasKey(e => e.IdTypeEmployee)
                    .HasName("PK__TYPE_EMP__9DBD5396069D0EB6");

                entity.ToTable("TYPE_EMPLOYEE");

                entity.Property(e => e.IdTypeEmployee).HasColumnName("id_type_employee");

                entity.Property(e => e.TypeEmployee1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("type_employee");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
