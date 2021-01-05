using System.Collections.Generic;

namespace Doctor_Office.Models
{
  public class Specialty
  {
    public Specialty()
    {
      this.Doctors = new HashSet<SpecialtyDoctor>();
    }

    public int SpecialtyId { get; set; }
    public string Name { get; set; }
    public ICollection<SpecialtyDoctor> Doctors { get; set; }
  }
}