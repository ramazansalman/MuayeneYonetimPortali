using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace MuayeneYonetimPortali.Tanimlamalar;

[ConnectionKey("Default"), Module("Tanimlamalar"), TableName("Departments")]
[DisplayName("Departments"), InstanceName("Departments")]
[ReadPermission("Tanimlamalar.Departments.General")]
[ModifyPermission("Tanimlamalar.Departments.General")]
[ServiceLookupPermission("Tanimlamalar.Departments.General")]
[LookupScript]
public sealed class DepartmentsRow : Row<DepartmentsRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Department Id"), Identity, IdProperty]
    public int? DepartmentId { get => fields.DepartmentId[this]; set => fields.DepartmentId[this] = value; }

    [DisplayName("Name"), Size(200), NotNull, QuickSearch, NameProperty]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field DepartmentId;
        public StringField Name;

    }
}