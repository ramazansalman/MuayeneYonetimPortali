using FluentMigrator;

namespace MuayeneYonetimPortali.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20250421_1130)]
public class DefaultDB_20250421_1130_Departments : AutoReversingMigration
{
    public override void Up()
    {
        Create.Table("Departments")
            .WithColumn("DepartmentId").AsInt32()
                .Identity().PrimaryKey().NotNullable()
            .WithColumn("Name").AsString(200).NotNullable()
            .WithColumn("HospitalId").AsInt32().NotNullable()
                .ForeignKey("Hospitals", "HospitalId");
    }
}