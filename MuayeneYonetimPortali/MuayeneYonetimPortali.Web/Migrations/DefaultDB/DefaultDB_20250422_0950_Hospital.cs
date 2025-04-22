using FluentMigrator;

namespace MuayeneYonetimPortali.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20250422_0950)]
public class DefaultDB_20250422_0950_Hospital  : AutoReversingMigration
{
    public override void Up()
    {
        Alter.Table("Hospitals")
                    .AddColumn("DepartmentId").AsInt32().Nullable()
                        .ForeignKey("FK_Hospitals_DepartmentId", "Departments", "DepartmentId");
    }
}