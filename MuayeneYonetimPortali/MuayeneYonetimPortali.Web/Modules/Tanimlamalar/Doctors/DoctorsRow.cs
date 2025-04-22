using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace MuayeneYonetimPortali.Tanimlamalar;

[ConnectionKey("Default"), Module("Tanimlamalar"), TableName("Doctors")]
[DisplayName("Doctors"), InstanceName("Doctors")]
[ReadPermission("Tanimlamalar.Doctors.General")]
[ModifyPermission("Tanimlamalar.Doctors.General")]
[ServiceLookupPermission("Tanimlamalar.Doctors.General")]
public sealed class DoctorsRow : Row<DoctorsRow.RowFields>, IIdRow, INameRow
{
    const string jUser = nameof(jUser);
    const string jHospital = nameof(jHospital);
    const string jDepartment = nameof(jDepartment);

    [DisplayName("Doctor Id"), Identity, IdProperty]
    public int? DoctorId { get => fields.DoctorId[this]; set => fields.DoctorId[this] = value; }

    [DisplayName("User"), NotNull, ForeignKey(typeof(Administration.UserRow)), LeftJoin(jUser), TextualField(nameof(Username))]
    [LookupEditor(typeof(Administration.UserRow), Async = true)]
    public int? UserId { get => fields.UserId[this]; set => fields.UserId[this] = value; }

    [DisplayName("Name"), Size(200), NotNull, QuickSearch, NameProperty]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    [DisplayName("Surname"), Size(200), NotNull]
    public string Surname { get => fields.Surname[this]; set => fields.Surname[this] = value; }

    [DisplayName("Gender"), NotNull]
    public Gender? Gender { get => fields.Gender[this]; set => fields.Gender[this] = value; }

    [DisplayName("Birth Date"), NotNull]
    public DateTime? BirthDate { get => fields.BirthDate[this]; set => fields.BirthDate[this] = value; }

    [DisplayName("Hospital"), ForeignKey(typeof(HospitalsRow)), LeftJoin(jHospital), TextualField(nameof(HospitalName))]
    [ServiceLookupEditor(typeof(HospitalsRow), Service = "Tanimlamalar/Hospitals/List")]
    public int? HospitalId { get => fields.HospitalId[this]; set => fields.HospitalId[this] = value; }

    [DisplayName("Department"), ForeignKey(typeof(DepartmentsRow)), LeftJoin(jDepartment), TextualField(nameof(DepartmentName))]
    [LookupEditor(typeof(DepartmentsRow), Async = true)]
    public int? DepartmentId { get => fields.DepartmentId[this]; set => fields.DepartmentId[this] = value; }

    [DisplayName("Username"), Origin(jUser, nameof(Administration.UserRow.Username))]
    public string Username { get => fields.Username[this]; set => fields.Username[this] = value; }

    [DisplayName("Hospital Name"), Origin(jHospital, nameof(HospitalsRow.Name))]
    public string HospitalName { get => fields.HospitalName[this]; set => fields.HospitalName[this] = value; }

    [DisplayName("Department Name"), Origin(jDepartment, nameof(DepartmentsRow.Name))]
    public string DepartmentName { get => fields.DepartmentName[this]; set => fields.DepartmentName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field DoctorId;
        public Int32Field UserId;
        public StringField Name;
        public StringField Surname;
        //public Int32Field Gender;
        public EnumField<Gender> Gender;

        public DateTimeField BirthDate;
        public Int32Field HospitalId;
        public Int32Field DepartmentId;

        public StringField Username;
        public StringField HospitalName;
        public StringField DepartmentName;
    }
}