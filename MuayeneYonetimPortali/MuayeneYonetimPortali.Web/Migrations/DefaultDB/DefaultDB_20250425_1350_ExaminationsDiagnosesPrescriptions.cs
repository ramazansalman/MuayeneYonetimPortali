using FluentMigrator;

namespace MuayeneYonetimPortali.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20250424_1350)]
public class DefaultDB_20250425_1350_ExaminationsDiagnosesPrescriptions  : AutoReversingMigration
{
    public override void Up()
    {
        Create.Table("Examinations")
            .WithColumn("ExaminationId").AsInt32()
                .Identity().PrimaryKey().NotNullable()
            .WithColumn("AppointmentId").AsInt32().NotNullable()
                .ForeignKey("Appointments", "AppointmentId")
            .WithColumn("DoctorId").AsInt32().NotNullable()
                .ForeignKey("Doctors", "DoctorId")
            .WithColumn("PatientId").AsInt32().NotNullable()
                .ForeignKey("Patients", "PatientId")
            .WithColumn("Complaint").AsString(200).Nullable()
            .WithColumn("ExaminationDate").AsDateTime().Nullable()
            .WithColumn("DoctorNote").AsString(200).Nullable();

        Create.Table("Diagnoses")
            .WithColumn("DiagnosisId").AsInt32().PrimaryKey().Identity()
            .WithColumn("Code").AsString(200).Nullable()
            .WithColumn("Name").AsString(200).Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(true);

        Create.Table("ExaminationDiagnoses")
            .WithColumn("ExaminationId").AsInt32().NotNullable()
                .ForeignKey("Examinations", "ExaminationId")
            .WithColumn("DiagnosisId").AsInt32().NotNullable()
                .ForeignKey("Diagnoses", "DiagnosisId");

        Create.Table("Drugs")
            .WithColumn("DrugId").AsInt32().PrimaryKey().Identity()
            .WithColumn("Name").AsString(200).NotNullable()
            .WithColumn("DosageInfo").AsString(100).Nullable()
            .WithColumn("Description").AsString(300).Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(true);

        Create.Table("Prescriptions")
            .WithColumn("PrescriptionId").AsInt32().PrimaryKey().Identity()
            .WithColumn("ExaminationId").AsInt32().Nullable()
                .ForeignKey("Examinations", "ExaminationId")
            .WithColumn("DoctorId").AsInt32().NotNullable()
                .ForeignKey("Doctors", "DoctorId")
            .WithColumn("PatientId").AsInt32().NotNullable()
                .ForeignKey("Patients", "PatientId")
            .WithColumn("PrescriptionNote").AsString(200).Nullable()
            .WithColumn("PrescriptionDate").AsDateTime().Nullable();

        Create.Table("PrescriptionDrugs")
            .WithColumn("PrescriptionDrugId").AsInt32().PrimaryKey().Identity()
            .WithColumn("PrescriptionId").AsInt32().NotNullable()
                .ForeignKey("Prescriptions", "PrescriptionId")
            .WithColumn("DrugId").AsInt32().NotNullable()
                .ForeignKey("Drugs", "DrugId")
            .WithColumn("Usage").AsString(100).Nullable();

    }
}