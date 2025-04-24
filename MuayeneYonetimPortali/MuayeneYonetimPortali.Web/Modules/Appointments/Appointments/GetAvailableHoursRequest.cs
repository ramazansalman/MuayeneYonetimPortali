public class GetAvailableHoursRequest : ServiceRequest
{
    public int DoctorId { get; set; }
    public DateTime Date { get; set; }
}
