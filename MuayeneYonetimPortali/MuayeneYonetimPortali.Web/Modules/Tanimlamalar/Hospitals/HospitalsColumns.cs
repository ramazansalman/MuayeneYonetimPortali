using Serenity.ComponentModel;
using System.ComponentModel;

namespace MuayeneYonetimPortali.Tanimlamalar.Columns;

[ColumnsScript("Tanimlamalar.Hospitals")]
[BasedOnRow(typeof(HospitalsRow), CheckNames = true)]
public class HospitalsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int HospitalId { get; set; }
    [EditLink]
    public string Name { get; set; }
    public string DistrictName { get; set; }
    public string CityName{ get; set; }
}