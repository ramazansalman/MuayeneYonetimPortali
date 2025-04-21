using FluentMigrator;

namespace MuayeneYonetimPortali.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20250421_1056)]
public class DefaultDB_20250421_1056_City : AutoReversingMigration
{
    public override void Up()
    {
        Create.Table("City")
            .WithColumn("CityId").AsInt32()
                .Identity().PrimaryKey().NotNullable()
            .WithColumn("Name").AsString(200).NotNullable();
    }
}