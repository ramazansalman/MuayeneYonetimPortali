using Serenity.ComponentModel;

namespace MuayeneYonetimPortali.Tanimlamalar.Forms;

[FormScript("Tanimlamalar.Hospitals")]
[BasedOnRow(typeof(HospitalsRow), CheckNames = true)]
public class HospitalsForm
{
    public string Name { get; set; }
    public int DistrictId { get; set; }
}