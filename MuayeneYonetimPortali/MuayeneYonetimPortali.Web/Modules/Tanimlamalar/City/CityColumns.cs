using Serenity.ComponentModel;
using System.ComponentModel;

namespace MuayeneYonetimPortali.Tanimlamalar.Columns;

[ColumnsScript("Tanimlamalar.City")]
[BasedOnRow(typeof(CityRow), CheckNames = true)]
public class CityColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int CityId { get; set; }
    [EditLink]
    public string Name { get; set; }
}