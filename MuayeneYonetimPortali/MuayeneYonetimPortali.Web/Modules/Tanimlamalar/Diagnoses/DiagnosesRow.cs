using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace MuayeneYonetimPortali.Tanimlamalar;

[ConnectionKey("Default"), Module("Tanimlamalar"), TableName("Diagnoses")]
[DisplayName("Diagnoses"), InstanceName("Diagnoses")]
[ReadPermission("Tanimlamalar.Diagnoses.General")]
[ModifyPermission("Tanimlamalar.Diagnoses.General")]
[ServiceLookupPermission("Tanimlamalar.Diagnoses.General")]
public sealed class DiagnosesRow : Row<DiagnosesRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Diagnosis Id"), Identity, IdProperty]
    public int? DiagnosisId { get => fields.DiagnosisId[this]; set => fields.DiagnosisId[this] = value; }

    [DisplayName("Code"), Size(200), QuickSearch, NameProperty]
    public string Code { get => fields.Code[this]; set => fields.Code[this] = value; }

    [DisplayName("Name"), Size(200)]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    [DisplayName("Is Active"), NotNull]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field DiagnosisId;
        public StringField Code;
        public StringField Name;
        public BooleanField IsActive;

    }
}