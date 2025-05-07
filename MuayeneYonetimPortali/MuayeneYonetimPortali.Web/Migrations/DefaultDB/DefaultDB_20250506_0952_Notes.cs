using FluentMigrator;

namespace MuayeneYonetimPortali.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20250506_0952)]
public class DefaultDB_20250506_0952_Notes  : AutoReversingMigration
{
    public override void Up()
    {
        Create.Table("Notes")
            .WithColumn("NoteID").AsInt64().IdentityKey(this)
            .WithColumn("EntityType").AsString(100).NotNullable()
            .WithColumn("EntityID").AsString().NotNullable()
            .WithColumn("Text").AsString(int.MaxValue).NotNullable()
            .WithColumn("InsertUserId").AsInt32().Nullable()
            .WithColumn("InsertDate").AsDateTime().NotNullable();
    }
}