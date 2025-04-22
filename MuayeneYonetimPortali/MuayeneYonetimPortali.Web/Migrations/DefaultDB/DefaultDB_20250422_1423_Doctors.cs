using FluentMigrator;

namespace MuayeneYonetimPortali.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20250422_1423)]
public class DefaultDB_20250422_1423_Doctors  : ForwardOnlyMigration
{
    public override void Up()
    {
        Create.Table("Doctors")
            .WithColumn("DoctorId").AsInt32()
                .Identity().PrimaryKey().NotNullable()
            .WithColumn("UserId").AsInt32().NotNullable()
                .ForeignKey("Users", "UserId")
            .WithColumn("Name").AsString(200).NotNullable()
            .WithColumn("Surname").AsString(200).NotNullable()
            .WithColumn("Gender").AsInt32().NotNullable()
            .WithColumn("BirthDate").AsDateTime().NotNullable()
            .WithColumn("HospitalId").AsInt32().Nullable()
                .ForeignKey("Hospitals", "HospitalId")
            .WithColumn("DepartmentId").AsInt32().Nullable()
                .ForeignKey("Departments", "DepartmentId");

        Create.Table("Patients")
            .WithColumn("PatientId").AsInt32()
                .Identity().PrimaryKey().NotNullable()
            .WithColumn("UserId").AsInt32().NotNullable()
                .ForeignKey("Users", "UserId")
            .WithColumn("Name").AsString(200).NotNullable()
            .WithColumn("Surname").AsString(200).NotNullable()
            .WithColumn("Gender").AsInt32().NotNullable()
            .WithColumn("BirthDate").AsDateTime().NotNullable();
    }
}