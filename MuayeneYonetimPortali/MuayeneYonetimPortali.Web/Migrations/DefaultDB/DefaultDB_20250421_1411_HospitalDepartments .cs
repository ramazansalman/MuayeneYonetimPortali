using FluentMigrator;

namespace MuayeneYonetimPortali.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20250421_1411)]
public class DefaultDB_20250421_1411_HospitalDepartments  : AutoReversingMigration
{
    public override void Up()
    {
        Create.Table("HospitalDepartments")
            .WithColumn("HospitalDepartmentId").AsInt32().Identity().PrimaryKey().NotNullable()
            .WithColumn("HospitalId").AsInt32().NotNullable().ForeignKey("Hospitals", "HospitalId")
            .WithColumn("DepartmentId").AsInt32().NotNullable().ForeignKey("Departments", "DepartmentId");

        Create.UniqueConstraint("UQ_Hospital_Department")
            .OnTable("HospitalDepartments")
            .Columns("HospitalId", "DepartmentId");
    }
}