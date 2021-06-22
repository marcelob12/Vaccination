using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Vaccination.SqlServerContext
{
    public partial class Proyecto_DB_POOContext : DbContext
    {
        public Proyecto_DB_POOContext()
        {
        }

        public Proyecto_DB_POOContext(DbContextOptions<Proyecto_DB_POOContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Cabin> Cabins { get; set; }
        public virtual DbSet<CabinxCitizen> CabinxCitizens { get; set; }
        public virtual DbSet<Charge> Charges { get; set; }
        public virtual DbSet<Citizen> Citizens { get; set; }
        public virtual DbSet<Disease> Diseases { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<Register> Registers { get; set; }
        public virtual DbSet<SecondaryEffect> SecondaryEffects { get; set; }
        public virtual DbSet<Type> Types { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Proyecto_DB_POO;Trusted_Connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.ToTable("APPOINTMENT");

                entity.Property(e => e.Dui)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FirstDate)
                    .HasColumnType("datetime")
                    .HasColumnName("First_date");

                entity.Property(e => e.IdCabin).HasColumnName("id_cabin");

                entity.Property(e => e.SecondDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Second_date");

                entity.Property(e => e.VaccinationPlace)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Vaccination_place");

                entity.HasOne(d => d.DuiNavigation)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.Dui)
                    .HasConstraintName("FK__APPOINTMENT__Dui__5165187F");

                entity.HasOne(d => d.IdCabinNavigation)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.IdCabin)
                    .HasConstraintName("FK__APPOINTME__id_ca__5070F446");
            });

            modelBuilder.Entity<Cabin>(entity =>
            {
                entity.ToTable("CABIN");

                entity.Property(e => e.AddressCabin)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("address_cabin");

                entity.Property(e => e.CabinPhone)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("cabin_phone");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Manager)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CabinxCitizen>(entity =>
            {
                entity.HasKey(e => new { e.Dui, e.IdCabin })
                    .HasName("PK__CABINxCI__55F00C0439D34C41");

                entity.ToTable("CABINxCITIZEN");

                entity.Property(e => e.Dui)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCabin).HasColumnName("Id_Cabin");

                entity.HasOne(d => d.DuiNavigation)
                    .WithMany(p => p.CabinxCitizens)
                    .HasForeignKey(d => d.Dui)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CABINxCITIZ__Dui__534D60F1");

                entity.HasOne(d => d.IdCabinNavigation)
                    .WithMany(p => p.CabinxCitizens)
                    .HasForeignKey(d => d.IdCabin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CABINxCIT__Id_Ca__5441852A");
            });

            modelBuilder.Entity<Charge>(entity =>
            {
                entity.ToTable("CHARGE");

                entity.Property(e => e.NameCharge)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Name_Charge");
            });

            modelBuilder.Entity<Citizen>(entity =>
            {
                entity.HasKey(e => e.Dui)
                    .HasName("PK__CITIZEN__C0317D901C6D7B92");

                entity.ToTable("CITIZEN");

                entity.Property(e => e.Dui)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CitizenAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Citizen_address");

                entity.Property(e => e.DateArrival)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Arrival");

                entity.Property(e => e.DateVaccine)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Vaccine");

                entity.Property(e => e.Email)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Full_name");

                entity.Property(e => e.IdCharge).HasColumnName("Id_Charge");

                entity.Property(e => e.IdDisease).HasColumnName("Id_Disease");

                entity.Property(e => e.IdRecord).HasColumnName("Id_Record");

                entity.Property(e => e.IdSecEffect).HasColumnName("Id_Sec_Effect");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("phone_number");

                entity.HasOne(d => d.IdChargeNavigation)
                    .WithMany(p => p.Citizens)
                    .HasForeignKey(d => d.IdCharge)
                    .HasConstraintName("FK__CITIZEN__Id_Char__4D94879B");

                entity.HasOne(d => d.IdDiseaseNavigation)
                    .WithMany(p => p.Citizens)
                    .HasForeignKey(d => d.IdDisease)
                    .HasConstraintName("FK__CITIZEN__Id_Dise__4F7CD00D");

                entity.HasOne(d => d.IdSecEffectNavigation)
                    .WithMany(p => p.Citizens)
                    .HasForeignKey(d => d.IdSecEffect)
                    .HasConstraintName("FK__CITIZEN__Id_Sec___4E88ABD4");
            });

            modelBuilder.Entity<Disease>(entity =>
            {
                entity.ToTable("DISEASE");

                entity.Property(e => e.DiseaseName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Disease_Name");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("EMPLOYEE");

                entity.Property(e => e.EmployeeAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Employee_address");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("full_name");

                entity.Property(e => e.IdCabin).HasColumnName("id_cabin");

                entity.Property(e => e.IdType).HasColumnName("id_type");

                entity.Property(e => e.InstitutionalMail)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("institutional_mail");

                entity.HasOne(d => d.IdCabinNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.IdCabin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EMPLOYEE__id_cab__4BAC3F29");

                entity.HasOne(d => d.IdTypeNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.IdType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EMPLOYEE__id_typ__4CA06362");
            });

            modelBuilder.Entity<Manager>(entity =>
            {
                entity.ToTable("MANAGER");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IdCabin).HasColumnName("id_cabin");

                entity.Property(e => e.PasswordManager)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("password_manager");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.HasOne(d => d.IdCabinNavigation)
                    .WithMany(p => p.Managers)
                    .HasForeignKey(d => d.IdCabin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MANAGER__id_cabi__4AB81AF0");
            });

            modelBuilder.Entity<Register>(entity =>
            {
                entity.ToTable("REGISTER");

                entity.Property(e => e.DateCabine)
                    .HasColumnType("datetime")
                    .HasColumnName("date_cabine");

                entity.Property(e => e.IdCabin).HasColumnName("id_cabin");

                entity.Property(e => e.IdManager).HasColumnName("id_manager");

                entity.HasOne(d => d.IdCabinNavigation)
                    .WithMany(p => p.Registers)
                    .HasForeignKey(d => d.IdCabin)
                    .HasConstraintName("FK__REGISTER__id_cab__48CFD27E");

                entity.HasOne(d => d.IdManagerNavigation)
                    .WithMany(p => p.Registers)
                    .HasForeignKey(d => d.IdManager)
                    .HasConstraintName("FK__REGISTER__id_man__49C3F6B7");
            });

            modelBuilder.Entity<SecondaryEffect>(entity =>
            {
                entity.ToTable("SECONDARY_EFFECT");

                entity.Property(e => e.SecEffect)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SEC_EFFECT");
            });

            modelBuilder.Entity<Type>(entity =>
            {
                entity.ToTable("TYPE_");

                entity.Property(e => e.TypeEmployee)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Type_Employee");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
