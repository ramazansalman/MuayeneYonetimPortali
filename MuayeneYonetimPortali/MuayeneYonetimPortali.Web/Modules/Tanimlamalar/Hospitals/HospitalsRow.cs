﻿using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace MuayeneYonetimPortali.Tanimlamalar;

[ConnectionKey("Default"), Module("Tanimlamalar"), TableName("Hospitals")]
[DisplayName("Hospitals"), InstanceName("Hospitals")]
[ReadPermission("Tanimlamalar.Hospitals.General")]
[ModifyPermission("Tanimlamalar.Hospitals.General")]
[ServiceLookupPermission("Tanimlamalar.Hospitals.General")]
public sealed class HospitalsRow : Row<HospitalsRow.RowFields>, IIdRow, INameRow
{
    const string jDistrict = nameof(jDistrict);
    const string jCity = nameof(jCity);
    const string jDepartment = nameof(jDepartment);

    [DisplayName("Hospital Id"), Identity, IdProperty]
    public int? HospitalId { get => fields.HospitalId[this]; set => fields.HospitalId[this] = value; }

    [DisplayName("Name"), Size(200), NotNull, QuickSearch, NameProperty]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    [DisplayName("District"), NotNull, ForeignKey(typeof(DistrictsRow)), LeftJoin(jDistrict), TextualField(nameof(DistrictName))]
    [ServiceLookupEditor(typeof(DistrictsRow), Service = "Tanimlamalar/Districts/List", CascadeFrom = nameof(DistrictsRow.CityId))]
    public int? DistrictId { get => fields.DistrictId[this]; set => fields.DistrictId[this] = value; }

    [DisplayName("District Name"), Origin(jDistrict, nameof(DistrictsRow.Name))]
    public string DistrictName { get => fields.DistrictName[this]; set => fields.DistrictName[this] = value; }

    [DisplayName("City"), Origin(jDistrict, nameof(DistrictsRow.CityId)), ForeignKey(typeof(CityRow)), LeftJoin(jCity)]
    [ServiceLookupEditor(typeof(CityRow), Service = "Tanimlamalar/City/List")]
    public int? CityId { get => fields.CityId[this]; set => fields.CityId[this] = value; }

    [DisplayName("City Name"), Origin(jCity, nameof(CityRow.Name))]
    public string CityName { get => fields.CityName[this]; set => fields.CityName[this] = value; }
    
    [DisplayName("Departments"), LookupEditor(typeof(DepartmentsRow), Multiple = true), NotMapped]
    [LinkingSetRelation(typeof(HospitalDepartmentsRow), nameof(HospitalDepartmentsRow.HospitalId), nameof(HospitalDepartmentsRow.DepartmentId))]
    public List<int> DepartmentList { get => fields.DepartmentList[this]; set => fields.DepartmentList[this] = value; }

    // [DisplayName("Departments"), ForeignKey(typeof(DepartmentsRow)), LeftJoin(jDepartment)]
    // [LookupEditor(typeof(DepartmentsRow), InplaceAdd = true, DialogType ="Tanimlamalar.Departments")]
    // public int? DepartmentId { get => fields.DepartmentId[this]; set => fields.DepartmentId[this] = value; }

    // [DisplayName("Departments"), Expression($"{jDepartment}.Name")]
    // public string DepartmentName { get => fields.DepartmentName[this]; set => fields.DepartmentName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field HospitalId;
        public StringField Name;
        public Int32Field DistrictId;
        public StringField DistrictName;
        public Int32Field CityId;
        public StringField CityName;
        // public Int32Field DepartmentId;
        // public StringField DepartmentName;
        public ListField<int> DepartmentList;


    }
}