using FluentMigrator;

namespace MuayeneYonetimPortali.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20250421_1117)]
public class DefaultDB_20250421_1117_Hospitals : AutoReversingMigration
{
    public override void Up()
    {
        Create.Table("Hospitals")
            .WithColumn("HospitalId").AsInt32()
                .Identity().PrimaryKey().NotNullable()
            .WithColumn("Name").AsString(200).NotNullable()
            .WithColumn("DistrictId").AsInt32().NotNullable()
                .ForeignKey("Districts", "DistrictId");
    }
}