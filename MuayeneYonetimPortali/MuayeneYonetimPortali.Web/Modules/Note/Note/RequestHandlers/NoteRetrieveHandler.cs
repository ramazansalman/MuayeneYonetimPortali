using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MuayeneYonetimPortali.Note.NoteRow>;
using MyRow = MuayeneYonetimPortali.Note.NoteRow;

namespace MuayeneYonetimPortali.Note;

public interface INoteRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class NoteRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, INoteRetrieveHandler
{
    public NoteRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}