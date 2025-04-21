using FluentMigrator;

namespace MuayeneYonetimPortali.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20250421_1101)]
public class DefaultDB_20250421_1101_District : AutoReversingMigration
{
    public override void Up()
    {
        Create.Table("Districts")
            .WithColumn("DistrictId").AsInt32()
                .Identity().PrimaryKey().NotNullable()
            .WithColumn("Name").AsString(200).NotNullable()
            .WithColumn("CityId").AsInt32().NotNullable()
                .ForeignKey("City", "CityId");
    }
}