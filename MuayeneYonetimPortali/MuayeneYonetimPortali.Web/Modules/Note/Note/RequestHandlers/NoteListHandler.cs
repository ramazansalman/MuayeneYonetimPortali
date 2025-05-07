using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MuayeneYonetimPortali.Note.NoteRow>;
using MyRow = MuayeneYonetimPortali.Note.NoteRow;

namespace MuayeneYonetimPortali.Note;

public interface INoteListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class NoteListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, INoteListHandler
{
    public NoteListHandler(IRequestContext context)
            : base(context)
    {
    }
}