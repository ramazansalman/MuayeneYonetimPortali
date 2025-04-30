using FastReport;
using FastReport.Export.PdfSimple;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using MuayeneYonetimPortali.Tanimlamalar;
using Serenity.Data;
using Serenity.Reporting;
using Serenity.Services;
using Serenity.Web;
using System;
using System.Data;
using System.Globalization;
using System.IO;
using MyRow = MuayeneYonetimPortali.Prescriptions.PrescriptionsRow;

namespace MuayeneYonetimPortali.Prescriptions.Endpoints;

[Route("Services/Prescriptions/Prescriptions/[action]")]
[ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
public class PrescriptionsEndpoint : ServiceEndpoint
{
    private readonly IWebHostEnvironment _env;
    public PrescriptionsEndpoint(IWebHostEnvironment env)
    {
      _env = env;
    }
    [HttpPost, AuthorizeCreate(typeof(MyRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IPrescriptionsSaveHandler handler)
    {
        return handler.Create(uow, request);
    }

    [HttpPost, AuthorizeUpdate(typeof(MyRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IPrescriptionsSaveHandler handler)
    {
        return handler.Update(uow, request);
    }
 
    [HttpPost, AuthorizeDelete(typeof(MyRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
        [FromServices] IPrescriptionsDeleteHandler handler)
    {
        return handler.Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
        [FromServices] IPrescriptionsRetrieveHandler handler)
    {
        return handler.Retrieve(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
        [FromServices] IPrescriptionsListHandler handler)
    {
        return handler.List(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
        [FromServices] IPrescriptionsListHandler handler,
        [FromServices] IExcelExporter exporter)
    {
        var data = List(connection, request, handler).Entities;
        var bytes = exporter.Export(data, typeof(Columns.PrescriptionsColumns), request.ExportColumns);
        return ExcelContentResult.Create(bytes, "PrescriptionsList_" +
            DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
    }

    [HttpPost]
    public FileContentResult Makbuz(IDbConnection connection, RetrieveRequest request, 
    [FromServices] PrescriptionsRetrieveHandler handler)
    {
        var report = new Report();
        var fileName = Path.Combine(_env.ContentRootPath, "wwwroot", "Report", "denemerecete.frx");

        report.Load(fileName);

        //var user = (Authorization.UserDefinition as UserDefinition);

        var data = new DataSet("Data");
        data.Tables.Add(GetData(connection, request, handler));
        //report.RegisterData(data);
        report.RegisterData(data, "Prescriptions", true);
        report.GetDataSource("Prescriptions").Enabled = true;
        report.Prepare();

        using MemoryStream ms = new();
        report.Export(new PDFSimpleExport(), ms);
        ms.Flush();
        return File(ms.ToArray(), "application/pdf");
    }

    private DataTable GetData(IDbConnection connection, RetrieveRequest request, IPrescriptionsRetrieveHandler handler)
    {
        var row = Retrieve(connection, request, handler).Entity;

        var dt = new DataTable("Prescriptions");
        //dt.Columns.Add("PatientId", typeof(string));
        dt.Columns.Add("PrescriptionDate", typeof(DateTime));
        dt.Columns.Add("PrescriptionNote", typeof(string));
        dt.Columns.Add("PatientId", typeof(int));
        dt.Columns.Add("PrescriptionId", typeof(int));


        dt.Rows.Add(row.PrescriptionDate, row.PrescriptionNote, row.PatientId, row.PrescriptionId);
        return dt;
    }
}