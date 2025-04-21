using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace MuayeneYonetimPortali.Tanimlamalar;

[ConnectionKey("Default"), Module("Tanimlamalar"), TableName("Districts")]
[DisplayName("Districts"), InstanceName("Districts")]
[ReadPermission("Tanimlamalar.Districts.General")]
[ModifyPermission("Tanimlamalar.Districts.General")]
[ServiceLookupPermission("Tanimlamalar.Districts.General")]
[LookupScript]
public sealed class DistrictsRow : Row<DistrictsRow.RowFields>, IIdRow, INameRow
{
    const string jCity = nameof(jCity);

    [DisplayName("District Id"), Identity, IdProperty]
    public int? DistrictId { get => fields.DistrictId[this]; set => fields.DistrictId[this] = value; }

    [DisplayName("Name"), Size(200), NotNull, QuickSearch, NameProperty]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    [DisplayName("City"), NotNull, ForeignKey(typeof(CityRow)), LeftJoin(jCity), TextualField(nameof(CityName))]
    [ServiceLookupEditor(typeof(CityRow), Service = "Tanimlamalar/City/List"), LookupInclude]
    public int? CityId { get => fields.CityId[this]; set => fields.CityId[this] = value; }

    [DisplayName("City Name"), Origin(jCity, nameof(CityRow.Name))]
    public string CityName { get => fields.CityName[this]; set => fields.CityName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field DistrictId;
        public StringField Name;
        public Int32Field CityId;

        public StringField CityName;
    }
}