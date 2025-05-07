using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace MuayeneYonetimPortali.Note;

public partial class NotesEditorAttribute : CustomEditorAttribute
{
    public const string Key = "MuayeneYonetimPortali.Note.NotesEditor";

    public NotesEditorAttribute()
        : base(Key)
    {
    }
}