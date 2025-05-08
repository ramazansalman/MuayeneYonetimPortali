using FluentMigrator;

namespace MuayeneYonetimPortali.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20250507_1253)]
public class DefaultDB_20250507_1253_Patients  : ForwardOnlyMigration
{
    public override void Up()
    {
        // Alter.Table("Notes")
        //     .AlterColumn("InsertDate").AsDateTime().NotNullable().WithDefault(SystemMethods.CurrentDateTime);
        Alter.Table("Patients")
            .AddColumn("IsActive").AsInt16().WithDefaultValue(1);
    }
}