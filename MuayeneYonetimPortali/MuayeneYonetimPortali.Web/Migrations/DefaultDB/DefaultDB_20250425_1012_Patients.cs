using FluentMigrator;

namespace MuayeneYonetimPortali.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20250425_1012)]
public class DefaultDB_20250425_1012_Patients  : AutoReversingMigration
{
    public override void Up()
    {
        Alter.Table("Patients")
            .AddColumn("Phone").AsString(20).NotNullable()
            .AddColumn("Email").AsString(100).Nullable()
            .AddColumn("TCKN").AsString(11).NotNullable();
    }
}