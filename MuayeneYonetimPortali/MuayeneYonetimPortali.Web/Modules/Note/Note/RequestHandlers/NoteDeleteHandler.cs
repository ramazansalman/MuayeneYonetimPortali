using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MuayeneYonetimPortali.Note.NoteRow;

namespace MuayeneYonetimPortali.Note;

public interface INoteDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class NoteDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, INoteDeleteHandler
{
    public NoteDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}