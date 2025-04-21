using Serenity.ComponentModel;
using System.ComponentModel;

namespace MuayeneYonetimPortali.Tanimlamalar.Columns;

[ColumnsScript("Tanimlamalar.Districts")]
[BasedOnRow(typeof(DistrictsRow), CheckNames = true)]
public class DistrictsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int DistrictId { get; set; }
    [EditLink]
    public string Name { get; set; }
    public string CityName { get; set; }
}