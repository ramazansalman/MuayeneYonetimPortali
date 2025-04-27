using Serenity.ComponentModel;
using System.ComponentModel;

namespace MuayeneYonetimPortali.Tanimlamalar.Columns;

[ColumnsScript("Tanimlamalar.Drugs")]
[BasedOnRow(typeof(DrugsRow), CheckNames = true)]
public class DrugsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int DrugId { get; set; }
    [EditLink]
    public string Name { get; set; }
    public bool IsActive { get; set; }
    public string Barcode { get; set; }
    public string CompanyName { get; set; }
    public string AtcCode { get; set; }
    public string AtcName { get; set; }
}