using System.Collections.Generic;

namespace Doctor_Office.Models
{
  public class Doctor
  {
    public Doctor()
    {
      this.Patients = new HashSet<DoctorPatient>();
      this.Specialties = new HashSet<SpecialtyDoctor>();
    }

    public int DoctorId { get; set; }
    public string Name { get; set; }

    public ICollection<DoctorPatient> Patients { get; set; }
    public ICollection<SpecialtyDoctor> Specialties { get; }
  }
}