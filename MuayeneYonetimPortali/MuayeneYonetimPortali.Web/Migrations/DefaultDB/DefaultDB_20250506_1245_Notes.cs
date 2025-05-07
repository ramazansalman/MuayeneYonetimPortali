using FluentMigrator;

namespace MuayeneYonetimPortali.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20250506_1245)]
public class DefaultDB_20250506_1245_Notes  : ForwardOnlyMigration
{
    public override void Up()
    {
        // Alter.Table("Notes")
        //     .AlterColumn("InsertDate").AsDateTime().NotNullable().WithDefault(SystemMethods.CurrentDateTime);
        Alter.Table("Notes")
            .AlterColumn("InsertDate").AsDateTime().NotNullable();
            
    }
}