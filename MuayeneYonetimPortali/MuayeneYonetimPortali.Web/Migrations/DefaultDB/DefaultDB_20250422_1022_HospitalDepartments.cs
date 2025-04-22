using FluentMigrator;

namespace MuayeneYonetimPortali.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20250422_1022)]
public class DefaultDB_20250422_1022_HospitalDepartments  : ForwardOnlyMigration
{
    public override void Up()
    {
        Create.Table("HospitalDepartments")
            .WithColumn("HospitalDepartmentId").AsInt32().Identity().PrimaryKey().NotNullable()
            .WithColumn("HospitalId").AsInt32().NotNullable().ForeignKey("FK_HospitalDepartments_HospitalId","Hospitals", "HospitalId")
            .WithColumn("DepartmentId").AsInt32().NotNullable().ForeignKey("FK_HospitalDepartments_DepartmentId","Departments", "DepartmentId");

        Execute.Sql(
            @"INSERT INTO HospitalDepartments (HospitalId, DepartmentId) 
                SELECT m.HospitalId, m.DepartmentId 
                FROM Hospitals m 
                WHERE m.DepartmentId IS NOT NULL");

        Delete.ForeignKey("FK_Hospitals_DepartmentId")
            .OnTable("Hospitals");
        Delete.Column("DepartmentId")
            .FromTable("Hospitals");
    }
}