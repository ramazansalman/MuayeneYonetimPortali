using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace MuayeneYonetimPortali.Examinations;

[ConnectionKey("Default"), Module("Examinations"), TableName("Examinations")]
[DisplayName("Examinations"), InstanceName("Examinations")]
[ReadPermission("Examinations.Examinations.General")]
[ModifyPermission("Examinations.Examinations.General")]
[ServiceLookupPermission("Examinations.Examinations.General")]
public sealed class ExaminationsRow : Row<ExaminationsRow.RowFields>, IIdRow, INameRow
{
    const string jAppointment = nameof(jAppointment);
    const string jDoctor = nameof(jDoctor);
    const string jPatient = nameof(jPatient);

    [DisplayName("Examination Id"), Identity, IdProperty]
    public int? ExaminationId { get => fields.ExaminationId[this]; set => fields.ExaminationId[this] = value; }

    [DisplayName("Appointment"), NotNull, ForeignKey(typeof(Appointments.AppointmentsRow)), LeftJoin(jAppointment)]
    [ServiceLookupEditor(typeof(Appointments.AppointmentsRow), Service = "Appointments/Appointments/List")]
    public int? AppointmentId { get => fields.AppointmentId[this]; set => fields.AppointmentId[this] = value; }

    [DisplayName("Doctor"), NotNull, ForeignKey(typeof(Tanimlamalar.DoctorsRow)), LeftJoin(jDoctor), TextualField(nameof(DoctorName))]
    [ServiceLookupEditor(typeof(Tanimlamalar.DoctorsRow), Service = "Tanimlamalar/Doctors/List")]
    public int? DoctorId { get => fields.DoctorId[this]; set => fields.DoctorId[this] = value; }

    [DisplayName("Patient"), NotNull, ForeignKey(typeof(Tanimlamalar.PatientsRow)), LeftJoin(jPatient), TextualField(nameof(PatientName))]
    [ServiceLookupEditor(typeof(Tanimlamalar.PatientsRow), Service = "Tanimlamalar/Patients/List")]
    public int? PatientId { get => fields.PatientId[this]; set => fields.PatientId[this] = value; }

    [DisplayName("Complaint"), Size(200), QuickSearch, NameProperty]
    public string Complaint { get => fields.Complaint[this]; set => fields.Complaint[this] = value; }

    [DisplayName("Examination Date")]
    public DateTime? ExaminationDate { get => fields.ExaminationDate[this]; set => fields.ExaminationDate[this] = value; }

    [DisplayName("Doctor Note"), Size(200)]
    public string DoctorNote { get => fields.DoctorNote[this]; set => fields.DoctorNote[this] = value; }

    [DisplayName("Doctor Name"), Origin(jDoctor, nameof(Tanimlamalar.DoctorsRow.Name))]
    public string DoctorName { get => fields.DoctorName[this]; set => fields.DoctorName[this] = value; }

    [DisplayName("Patient Name"), Origin(jPatient, nameof(Tanimlamalar.PatientsRow.Name))]
    public string PatientName { get => fields.PatientName[this]; set => fields.PatientName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field ExaminationId;
        public Int32Field AppointmentId;
        public Int32Field DoctorId;
        public Int32Field PatientId;
        public StringField Complaint;
        public DateTimeField ExaminationDate;
        public StringField DoctorNote;

        public StringField DoctorName;
        public StringField PatientName;
    }
}