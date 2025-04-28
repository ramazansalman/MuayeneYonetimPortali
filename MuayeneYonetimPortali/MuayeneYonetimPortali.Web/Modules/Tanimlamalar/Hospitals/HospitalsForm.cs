using Serenity.ComponentModel;

namespace MuayeneYonetimPortali.Tanimlamalar.Forms;

[FormScript("Tanimlamalar.Hospitals")]
[BasedOnRow(typeof(HospitalsRow), CheckNames = true)]
public class HospitalsForm
{
    [OneWay]
    public int CityId { get; set; }
    public int DistrictId { get; set; }
    // public int DepartmentId { get; set; }
    public List<int> DepartmentList { get; set; }
    public string Name { get; set; }
}