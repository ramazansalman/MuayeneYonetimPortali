using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace MuayeneYonetimPortali.Examinations;

[ConnectionKey("Default"), Module("Examinations"), TableName("ExaminationDiagnoses")]
[DisplayName("Examination Diagnoses"), InstanceName("Examination Diagnoses")]
[ReadPermission("Examination.ExaminationDiagnoses.General")]
[ModifyPermission("Examination.ExaminationDiagnoses.General")]
public sealed class ExaminationDiagnosesRow : Row<ExaminationDiagnosesRow.RowFields>, IIdRow
{
    const string jExamination = nameof(jExamination);
    const string jDiagnosis = nameof(jDiagnosis);

    [DisplayName("Examination"), NotNull, ForeignKey("Examinations", "ExaminationId"), LeftJoin(jExamination), IdProperty]
    [TextualField(nameof(ExaminationComplaint))]
    public int? ExaminationId { get => fields.ExaminationId[this]; set => fields.ExaminationId[this] = value; }

    [DisplayName("Diagnosis"), NotNull, ForeignKey(typeof(Tanimlamalar.DiagnosesRow)), LeftJoin(jDiagnosis)]
    [TextualField(nameof(DiagnosisCode))]
    [ServiceLookupEditor(typeof(Tanimlamalar.DiagnosesRow), Service = "Tanimlamalar/Diagnoses/List")]
    public int? DiagnosisId { get => fields.DiagnosisId[this]; set => fields.DiagnosisId[this] = value; }

    [DisplayName("Examination Complaint"), Expression($"{jExamination}.[Complaint]")]
    public string ExaminationComplaint { get => fields.ExaminationComplaint[this]; set => fields.ExaminationComplaint[this] = value; }

    [DisplayName("Diagnosis Code"), Origin(jDiagnosis, nameof(Tanimlamalar.DiagnosesRow.Code))]
    public string DiagnosisCode { get => fields.DiagnosisCode[this]; set => fields.DiagnosisCode[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field ExaminationId;
        public Int32Field DiagnosisId;

        public StringField ExaminationComplaint;
        public StringField DiagnosisCode;
    }
}