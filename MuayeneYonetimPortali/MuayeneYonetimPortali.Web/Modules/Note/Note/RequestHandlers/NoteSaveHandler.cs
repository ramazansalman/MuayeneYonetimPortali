using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MuayeneYonetimPortali.Note.NoteRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MuayeneYonetimPortali.Note.NoteRow;

namespace MuayeneYonetimPortali.Note;

public interface INoteSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class NoteSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, INoteSaveHandler
{
    public NoteSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}