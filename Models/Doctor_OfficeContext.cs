using Microsoft.EntityFrameworkCore;

namespace Doctor_Office.Models
{
  public class Doctor_OfficeContext : DbContext
  {
    public virtual DbSet<Doctor> Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<DoctorPatient> DoctorPatient { get; set; }
    public DbSet<Specialty> Specialties { get; set; }
    public DbSet<SpecialtyDoctor> SpecialtyDoctor { get; set; }
    
    public Doctor_OfficeContext(DbContextOptions options) : base(options) { }
  }
}