using MuayeneYonetimPortali.Tanimlamalar;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace MuayeneYonetimPortali.Appointments;

[ConnectionKey("Default"), Module("Appointments"), TableName("Appointments")]
[DisplayName("Appointments"), InstanceName("Appointments")]
[ReadPermission("Appointments.General")]
[ModifyPermission("Appointments.General")]
public sealed class AppointmentsRow : Row<AppointmentsRow.RowFields>, IIdRow
{
    const string jCity = nameof(jCity);
    const string jDistrict = nameof(jDistrict);
    const string jHospital = nameof(jHospital);
    const string jDepartment = nameof(jDepartment);
    const string jDoctor = nameof(jDoctor);
    const string jPatient = nameof(jPatient);

    [DisplayName("Appointment Id"), Identity, IdProperty]
    public int? AppointmentId { get => fields.AppointmentId[this]; set => fields.AppointmentId[this] = value; }

    [DisplayName("City"), NotNull, ForeignKey(typeof(Tanimlamalar.CityRow)), LeftJoin(jCity), TextualField(nameof(CityName))]
    [ServiceLookupEditor(typeof(Tanimlamalar.CityRow), Service = "Tanimlamalar/City/List")]
    public int? CityId { get => fields.CityId[this]; set => fields.CityId[this] = value; }

    [DisplayName("District"), NotNull, ForeignKey(typeof(Tanimlamalar.DistrictsRow)), LeftJoin(jDistrict)]
    [TextualField(nameof(DistrictName)), LookupEditor(typeof(Tanimlamalar.DistrictsRow), Async = true, CascadeFrom =nameof(DistrictsRow.CityId))]
    public int? DistrictId { get => fields.DistrictId[this]; set => fields.DistrictId[this] = value; }

    [DisplayName("Hospital"), NotNull, ForeignKey(typeof(Tanimlamalar.HospitalsRow)), LeftJoin(jHospital)]
    [TextualField(nameof(HospitalName))]
    [ServiceLookupEditor(typeof(Tanimlamalar.HospitalsRow), Service = "Tanimlamalar/Hospitals/List", CascadeFrom =nameof(HospitalsRow.DistrictId))]
    public int? HospitalId { get => fields.HospitalId[this]; set => fields.HospitalId[this] = value; }

    [DisplayName("Department"), ForeignKey(typeof(Tanimlamalar.DepartmentsRow)), LeftJoin(jDepartment)]
    [TextualField(nameof(DepartmentName)), LookupEditor(typeof(Tanimlamalar.DepartmentsRow), Async = true)]
    public int? DepartmentId { get => fields.DepartmentId[this]; set => fields.DepartmentId[this] = value; }

    [DisplayName("Doctor"), NotNull, ForeignKey(typeof(Tanimlamalar.DoctorsRow)), LeftJoin(jDoctor), TextualField(nameof(DoctorName))]
    [ServiceLookupEditor(typeof(Tanimlamalar.DoctorsRow), Service = "Tanimlamalar/Doctors/List", CascadeFrom =nameof(DoctorsRow.DepartmentId))]
    public int? DoctorId { get => fields.DoctorId[this]; set => fields.DoctorId[this] = value; }

    [DisplayName("Patient"), NotNull, ForeignKey(typeof(Tanimlamalar.PatientsRow)), LeftJoin(jPatient), TextualField(nameof(PatientName))]
    [ServiceLookupEditor(typeof(Tanimlamalar.PatientsRow), Service = "Tanimlamalar/Patients/List")]
    public int? PatientId { get => fields.PatientId[this]; set => fields.PatientId[this] = value; }

    [DisplayName("Date"), NotNull]
    public DateTime? AppointmentDate { get => fields.AppointmentDate[this]; set => fields.AppointmentDate[this] = value; }

    [DisplayName("City"), Origin(jCity, nameof(Tanimlamalar.CityRow.Name))]
    public string CityName { get => fields.CityName[this]; set => fields.CityName[this] = value; }

    [DisplayName("District"), Origin(jDistrict, nameof(Tanimlamalar.DistrictsRow.Name))]
    public string DistrictName { get => fields.DistrictName[this]; set => fields.DistrictName[this] = value; }

    [DisplayName("Hospital"), Origin(jHospital, nameof(Tanimlamalar.HospitalsRow.Name))]
    public string HospitalName { get => fields.HospitalName[this]; set => fields.HospitalName[this] = value; }

    [DisplayName("Department"), Origin(jDepartment, nameof(Tanimlamalar.DepartmentsRow.Name))]
    public string DepartmentName { get => fields.DepartmentName[this]; set => fields.DepartmentName[this] = value; }

    [DisplayName("Doctor Name"), Origin(jDoctor, nameof(Tanimlamalar.DoctorsRow.Name))]
    public string DoctorName { get => fields.DoctorName[this]; set => fields.DoctorName[this] = value; }

    [DisplayName("Patient Name"), Origin(jPatient, nameof(Tanimlamalar.PatientsRow.Name))]
    public string PatientName { get => fields.PatientName[this]; set => fields.PatientName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field AppointmentId;
        public Int32Field CityId;
        public Int32Field DistrictId;
        public Int32Field HospitalId;
        public Int32Field DepartmentId;
        public Int32Field DoctorId;
        public Int32Field PatientId;
        public DateTimeField AppointmentDate;

        public StringField CityName;
        public StringField DistrictName;
        public StringField HospitalName;
        public StringField DepartmentName;
        public StringField DoctorName;
        public StringField PatientName;
    }
}