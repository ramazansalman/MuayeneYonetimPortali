using FluentMigrator;

namespace MuayeneYonetimPortali.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20250530_0926)]
public class DefaultDB_20250530_0926_TwoFactorCode  : AutoReversingMigration
{
    public override void Up()
    {
        Create.Table("TwoFactorCode")
            .WithColumn("Id").AsInt32().Identity().PrimaryKey().NotNullable()
            .WithColumn("UserId").AsInt32().NotNullable()
                .ForeignKey("FK_TwoFactorCode_UserId", "Users", "UserId")
            .WithColumn("Code").AsString(10).NotNullable()
            .WithColumn("ExpireTime").AsDateTime().NotNullable();
    }
}