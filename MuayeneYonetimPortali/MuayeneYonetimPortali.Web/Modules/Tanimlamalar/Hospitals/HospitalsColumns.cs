using Serenity.ComponentModel;
using System.ComponentModel;
using Tanimlamalar.Hospitals;

namespace MuayeneYonetimPortali.Tanimlamalar.Columns;

[ColumnsScript("Tanimlamalar.Hospitals")]
[BasedOnRow(typeof(HospitalsRow), CheckNames = true)]
public class HospitalsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId")]
    public int HospitalId { get; set; }
    [EditLink]
    public string Name { get; set; }
    [QuickFilter]
    public string CityName{ get; set; }
    public string DistrictName { get; set; }
    // public string DepartmentName { get; set; }
    [Width(200)][DepartmentsListFormatter]
    public List<int> DepartmentList { get; set; }

}