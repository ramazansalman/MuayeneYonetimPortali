using FluentMigrator;

namespace MuayeneYonetimPortali.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20250422_1558)]
public class DefaultDB_20250422_1558_Appointments  : AutoReversingMigration
{
    public override void Up()
    {
        Create.Table("Appointments")
                    .WithColumn("AppointmentId").AsInt32()
                        .Identity().PrimaryKey().NotNullable()
                    .WithColumn("CityId").AsInt32().NotNullable()
                        .ForeignKey("City", "CityId")
                    .WithColumn("DistrictId").AsInt32().NotNullable()
                        .ForeignKey("Districts", "DistrictId")
                    .WithColumn("HospitalId").AsInt32().NotNullable()
                        .ForeignKey("Hospitals", "HospitalId")
                    .WithColumn("DepartmentId").AsInt32().Nullable()
                        .ForeignKey("Departments", "DepartmentId")
                    .WithColumn("DoctorId").AsInt32().NotNullable()
                        .ForeignKey("Doctors", "DoctorId")
                    .WithColumn("PatientId").AsInt32().NotNullable()
                        .ForeignKey("Patients", "PatientId")
                    .WithColumn("AppointmentDate").AsDateTime().NotNullable();    
    }
}