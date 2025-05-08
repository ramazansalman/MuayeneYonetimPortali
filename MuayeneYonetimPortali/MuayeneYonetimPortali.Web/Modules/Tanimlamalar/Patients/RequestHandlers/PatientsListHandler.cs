using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MuayeneYonetimPortali.Tanimlamalar.PatientsRow>;
using MyRow = MuayeneYonetimPortali.Tanimlamalar.PatientsRow;

namespace MuayeneYonetimPortali.Tanimlamalar;

public interface IPatientsListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class PatientsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPatientsListHandler
{
    public PatientsListHandler(IRequestContext context)
            : base(context)
    {
    }
    // Sadece aktif olanlari listeler. Aktif degilse listelemez db den aktif yapmak gerekir.
    protected override void PrepareQuery(SqlQuery query)
    {
        base.PrepareQuery(query);
        var fld = PatientsRow.Fields;
        query.Where((new Criteria(fld.IsActive) == 1) || new Criteria(fld.IsActive) == 0); //sadece aktif ve pasif durumdaki hastalari getir (default 1de)
    }
}