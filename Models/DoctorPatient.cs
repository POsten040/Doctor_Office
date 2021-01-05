using System.Collections.Generic;

namespace Doctor_Office.Models
{
  public class DoctorPatient
  {
    public int DoctorPatientId { get; set; }
    public int PatientId { get; set; }
    public int DoctorId { get; set; }
    public Patient Patient { get; set; }
    public Doctor Doctor { get; set; }
  }
}