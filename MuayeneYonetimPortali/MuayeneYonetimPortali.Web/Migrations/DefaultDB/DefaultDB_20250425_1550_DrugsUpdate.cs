using FluentMigrator;

namespace MuayeneYonetimPortali.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20250425_1550)]
public class DefaultDB_20250425_1550_DrugsUpdate  : ForwardOnlyMigration
{
    public override void Up()
    {
        Alter.Table("Drugs")
            .AddColumn("Barcode").AsString(50).Nullable()
            .AddColumn("CompanyName").AsString(200).Nullable()
            .AddColumn("AtcCode").AsString(50).Nullable()
            .AddColumn("AtcName").AsString(200).Nullable();

        Delete.Column("DosageInfo").FromTable("Drugs");
        Delete.Column("Description").FromTable("Drugs");
    }
}