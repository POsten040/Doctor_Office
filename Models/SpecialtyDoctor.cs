using System.Collections.Generic;

namespace Doctor_Office.Models
{
  public class SpecialtyDoctor
  {
    public int SpecialtyDoctorId { get; set; }
    public int DoctorId { get; set; }
    public int SpecialtyId { get; set; }
    public Doctor Doctor { get; set; }
    public Specialty Specialty { get; set; }
  }
}