using FluentMigrator;

namespace MuayeneYonetimPortali.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20250530_0927)]
public class DefaultDB_20250530_0927_Users2FA  : ForwardOnlyMigration
{
    public override void Up()
    {
        Alter.Table("Users")
                .AddColumn("TwoFactorEnabled").AsBoolean().WithDefaultValue(false).NotNullable()
                .AddColumn("TwoFactorMethod").AsString(10).Nullable()
                .AddColumn("PhoneNumber").AsString(20).Nullable();

    }
}