using Serenity.ComponentModel;
using System.ComponentModel;

namespace MuayeneYonetimPortali.Tanimlamalar.Columns;

[ColumnsScript("Tanimlamalar.Diagnoses")]
[BasedOnRow(typeof(DiagnosesRow), CheckNames = true)]
public class DiagnosesColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int DiagnosisId { get; set; }
    [EditLink]
    public string Code { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; }
}