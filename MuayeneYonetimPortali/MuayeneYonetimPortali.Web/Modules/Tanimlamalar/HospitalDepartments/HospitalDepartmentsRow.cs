using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace MuayeneYonetimPortali.Tanimlamalar;

[ConnectionKey("Default"), Module("Tanimlamalar"), TableName("HospitalDepartments")]
[DisplayName("Hospital Departments"), InstanceName("Hospital Departments")]
[ReadPermission("Tanimlamalar.HospitalDepartments.General")]
[ModifyPermission("Tanimlamalar.HospitalDepartments.General")]
public sealed class HospitalDepartmentsRow : Row<HospitalDepartmentsRow.RowFields>, IIdRow
{
    const string jHospital = nameof(jHospital);
    const string jDepartment = nameof(jDepartment);

    [DisplayName("Hospital Department Id"), Identity, IdProperty]
    public int? HospitalDepartmentId { get => fields.HospitalDepartmentId[this]; set => fields.HospitalDepartmentId[this] = value; }

    [DisplayName("Hospital"), NotNull, ForeignKey(typeof(HospitalsRow)), LeftJoin(jHospital), TextualField(nameof(HospitalName))]
    [ServiceLookupEditor(typeof(HospitalsRow), Service = "Tanimlamalar/Hospitals/List")]
    public int? HospitalId { get => fields.HospitalId[this]; set => fields.HospitalId[this] = value; }

    [DisplayName("Department"), NotNull, ForeignKey(typeof(DepartmentsRow)), LeftJoin(jDepartment), TextualField(nameof(DepartmentName))]
    [LookupEditor(typeof(DepartmentsRow), Async = true)]
    public int? DepartmentId { get => fields.DepartmentId[this]; set => fields.DepartmentId[this] = value; }

    [DisplayName("Hospital Name"), Origin(jHospital, nameof(HospitalsRow.Name))]
    public string HospitalName { get => fields.HospitalName[this]; set => fields.HospitalName[this] = value; }

    [DisplayName("Department Name"), Origin(jDepartment, nameof(DepartmentsRow.Name))]
    public string DepartmentName { get => fields.DepartmentName[this]; set => fields.DepartmentName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field HospitalDepartmentId;
        public Int32Field HospitalId;
        public Int32Field DepartmentId;

        public StringField HospitalName;
        public StringField DepartmentName;
    }
}