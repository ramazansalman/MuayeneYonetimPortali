using MuayeneYonetimPortali.Tanimlamalar;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace MuayeneYonetimPortali.Prescriptions;

[ConnectionKey("Default"), Module("Prescriptions"), TableName("Prescriptions")]
[DisplayName("Prescriptions"), InstanceName("Prescriptions")]
[ReadPermission("Prescriptions.Prescriptions.General")]
[ModifyPermission("Prescriptions.Prescriptions.General")]
[ServiceLookupPermission("Prescriptions.Prescriptions.General")]
[LookupScript]
public sealed class PrescriptionsRow : Row<PrescriptionsRow.RowFields>, IIdRow, INameRow
{
    const string jExamination = nameof(jExamination);
    const string jDoctor = nameof(jDoctor);
    const string jPatient = nameof(jPatient);
    const string jDrug = nameof(jDrug);

    [DisplayName("Prescription Id"), Identity, IdProperty]
    public int? PrescriptionId { get => fields.PrescriptionId[this]; set => fields.PrescriptionId[this] = value; }

    [DisplayName("Examination"), ForeignKey("Examinations", "ExaminationId"), LeftJoin(jExamination)]
    [TextualField(nameof(ExaminationComplaint))]
    public int? ExaminationId { get => fields.ExaminationId[this]; set => fields.ExaminationId[this] = value; }

    [DisplayName("Doctor"), NotNull, ForeignKey(typeof(Tanimlamalar.DoctorsRow)), LeftJoin(jDoctor), TextualField(nameof(DoctorName))]
    [ServiceLookupEditor(typeof(Tanimlamalar.DoctorsRow), Service = "Tanimlamalar/Doctors/List")]
    public int? DoctorId { get => fields.DoctorId[this]; set => fields.DoctorId[this] = value; }

    [DisplayName("Patient"), NotNull, ForeignKey(typeof(Tanimlamalar.PatientsRow)), LeftJoin(jPatient), TextualField(nameof(PatientName))]
    [ServiceLookupEditor(typeof(Tanimlamalar.PatientsRow), Service = "Tanimlamalar/Patients/List")]
    public int? PatientId { get => fields.PatientId[this]; set => fields.PatientId[this] = value; }

    [DisplayName("Prescription Note"), Size(200), QuickSearch, NameProperty]
    public string PrescriptionNote { get => fields.PrescriptionNote[this]; set => fields.PrescriptionNote[this] = value; }

    [DisplayName("Prescription Date")]
    public DateTime? PrescriptionDate { get => fields.PrescriptionDate[this]; set => fields.PrescriptionDate[this] = value; }

    [DisplayName("Examination Complaint"), Expression($"{jExamination}.[Complaint]")]
    public string ExaminationComplaint { get => fields.ExaminationComplaint[this]; set => fields.ExaminationComplaint[this] = value; }

    [DisplayName("Doctor Name"), Origin(jDoctor, nameof(Tanimlamalar.DoctorsRow.Name))]
    public string DoctorName { get => fields.DoctorName[this]; set => fields.DoctorName[this] = value; }

    [DisplayName("Patient Name"), Origin(jPatient, nameof(Tanimlamalar.PatientsRow.Name))]
    public string PatientName { get => fields.PatientName[this]; set => fields.PatientName[this] = value; }

    [DisplayName("İlaçlar"), NotMapped, LookupEditor(typeof(DrugsRow), Multiple = true)]
    [LinkingSetRelation(typeof(PrescriptionDrugsRow), "PrescriptionId", "DrugId")]
    public List<int> DrugList { get => fields.DrugList[this]; set => fields.DrugList[this] = value;}
    public class RowFields : RowFieldsBase
    {
        public Int32Field PrescriptionId;
        public Int32Field ExaminationId;
        public Int32Field DoctorId;
        public Int32Field PatientId;
        public StringField PrescriptionNote;
        public DateTimeField PrescriptionDate;

        public StringField ExaminationComplaint;
        public StringField DoctorName;
        public StringField PatientName;
        public ListField<int> DrugList;
    }
}