using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace MuayeneYonetimPortali.Tanimlamalar;

[ConnectionKey("Default"), Module("Tanimlamalar"), TableName("Drugs")]
[DisplayName("Drugs"), InstanceName("Drugs")]
[ReadPermission("Tanimlamalar.Drugs.General")]
[ModifyPermission("Tanimlamalar.Drugs.General")]
[ServiceLookupPermission("Tanimlamalar.Drugs.General")]
[LookupScript]
public sealed class DrugsRow : Row<DrugsRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Drug Id"), Identity, IdProperty]
    public int? DrugId { get => fields.DrugId[this]; set => fields.DrugId[this] = value; }

    [DisplayName("Name"), Size(200), NotNull, QuickSearch, NameProperty]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    [DisplayName("Is Active"), NotNull]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Barcode"), Size(50)]
    public string Barcode { get => fields.Barcode[this]; set => fields.Barcode[this] = value; }

    [DisplayName("Company Name"), Size(200), QuickSearch]
    public string CompanyName { get => fields.CompanyName[this]; set => fields.CompanyName[this] = value; }

    [DisplayName("Atc Code"), Size(50)]
    public string AtcCode { get => fields.AtcCode[this]; set => fields.AtcCode[this] = value; }

    [DisplayName("Atc Name"), Size(200), QuickSearch]
    public string AtcName { get => fields.AtcName[this]; set => fields.AtcName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field DrugId;
        public StringField Name;
        public BooleanField IsActive;
        public StringField Barcode;
        public StringField CompanyName;
        public StringField AtcCode;
        public StringField AtcName;

    }
}