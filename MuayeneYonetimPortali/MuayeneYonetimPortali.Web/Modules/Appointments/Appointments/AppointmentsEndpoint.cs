using Microsoft.AspNetCore.Mvc;
using Serenity.Data;
using Serenity.Reporting;
using Serenity.Services;
using Serenity.Web;
using System;
using System.Data;
using System.Globalization;
using MyRow = MuayeneYonetimPortali.Appointments.AppointmentsRow;

namespace MuayeneYonetimPortali.Appointments.Endpoints;

[Route("Services/Appointments/Appointments/[action]")]
[ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
public class AppointmentsEndpoint : ServiceEndpoint
{
    [HttpPost, AuthorizeCreate(typeof(MyRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IAppointmentsSaveHandler handler)
    {
        return handler.Create(uow, request);
    }

    [HttpPost, AuthorizeUpdate(typeof(MyRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IAppointmentsSaveHandler handler)
    {
        return handler.Update(uow, request);
    }
 
    [HttpPost, AuthorizeDelete(typeof(MyRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
        [FromServices] IAppointmentsDeleteHandler handler)
    {
        return handler.Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
        [FromServices] IAppointmentsRetrieveHandler handler)
    {
        return handler.Retrieve(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
        [FromServices] IAppointmentsListHandler handler)
    {
        return handler.List(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
        [FromServices] IAppointmentsListHandler handler,
        [FromServices] IExcelExporter exporter)
    {
        var data = List(connection, request, handler).Entities;
        var bytes = exporter.Export(data, typeof(Columns.AppointmentsColumns), request.ExportColumns);
        return ExcelContentResult.Create(bytes, "AppointmentsList_" +
            DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public ListResponse<string> GetAvailableHours(IDbConnection connection, GetAvailableHoursRequest request)
    {
        var takenTimes = connection.Query<string>(
            @"SELECT FORMAT(AppointmentDate, 'HH:mm') 
            FROM Appointments 
            WHERE DoctorId = @DoctorId AND 
                    CAST(AppointmentDate AS DATE) = @Date",
            new { request.DoctorId, request.Date.Date }).ToList();

        var availableTimes = new List<string>();
        var start = new TimeSpan(8, 0, 0);
        var end = new TimeSpan(17, 0, 0);

        for (var time = start; time < end; time += TimeSpan.FromMinutes(20))
        {
            var timeStr = time.ToString(@"hh\:mm");
            if (!takenTimes.Contains(timeStr))
                availableTimes.Add(timeStr);
        }

        return new ListResponse<string> { Entities = availableTimes };
    }

}