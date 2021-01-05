using System.Collections.Generic;

namespace Doctor_Office.Models
{
  public class Patient
  {
    public Patient()
    {
      this.Doctors = new HashSet<DoctorPatient>();
    }

    public int PatientId { get; set; }
    public string Name { get; set; }
    public string Birthday { get; set; }

    public ICollection<DoctorPatient> Doctors { get; }
  }
}