using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace MuayeneYonetimPortali.Tanimlamalar;

[ConnectionKey("Default"), Module("Tanimlamalar"), TableName("City")]
[DisplayName("City"), InstanceName("City")]
[ReadPermission("Tanimlamalar.City.General")]
[ModifyPermission("Tanimlamalar.City.General")]
[ServiceLookupPermission("Tanimlamalar.City.General")]
public sealed class CityRow : Row<CityRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("City Id"), Identity, IdProperty]
    public int? CityId { get => fields.CityId[this]; set => fields.CityId[this] = value; }

    [DisplayName("Name"), Size(200), NotNull, QuickSearch, NameProperty]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field CityId;
        public StringField Name;

    }
}