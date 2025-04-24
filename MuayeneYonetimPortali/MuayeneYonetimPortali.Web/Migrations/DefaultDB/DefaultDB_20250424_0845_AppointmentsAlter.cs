using FluentMigrator;

namespace MuayeneYonetimPortali.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20250424_0845)]
public class DefaultDB_20250424_0845_AppointmentsAlter  : AutoReversingMigration
{
    public override void Up()
    {
        Alter.Table("Appointments")
            .AlterColumn("AppointmentDate ").AsDateTime2().NotNullable();    
    }
}