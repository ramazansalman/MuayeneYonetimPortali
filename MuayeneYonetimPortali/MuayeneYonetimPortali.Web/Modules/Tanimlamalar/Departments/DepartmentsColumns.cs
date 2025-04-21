using Serenity.ComponentModel;
using System.ComponentModel;

namespace MuayeneYonetimPortali.Tanimlamalar.Columns;

[ColumnsScript("Tanimlamalar.Departments")]
[BasedOnRow(typeof(DepartmentsRow), CheckNames = true)]
public class DepartmentsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int DepartmentId { get; set; }
    [EditLink]
    public string Name { get; set; }
}