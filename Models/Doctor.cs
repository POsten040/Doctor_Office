using System.Collections.Generic;

namespace Doctor_Office.Models
{
  public class Doctor
  {
    public Doctor()
    {
      this.Patients = new HashSet<DoctorPatient>();
    }

    public int DoctorId { get; set; }
    public string Name { get; set; }
    public string Specialty { get; set; }

    public ICollection<DoctorPatient> Patients { get; set; }
  }
}