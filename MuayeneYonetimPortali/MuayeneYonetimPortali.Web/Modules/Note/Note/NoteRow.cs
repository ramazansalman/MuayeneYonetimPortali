using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace MuayeneYonetimPortali.Note;

[ConnectionKey("Default"), Module("Note"), TableName("Notes")]
[DisplayName("Note"), InstanceName("Note")]
[ReadPermission("Note.General")]
[ModifyPermission("Note.General")]
[ServiceLookupPermission("Note.General")]
public sealed class NoteRow : Row<NoteRow.RowFields>, IIdRow, INameRow, ILoggingRow
{
    [DisplayName("Note Id"), Column("NoteID"), Identity, IdProperty]
    public long? NoteId { get => fields.NoteId[this]; set => fields.NoteId[this] = value; }

    [DisplayName("Entity Type"), Size(100), NotNull, QuickSearch, NameProperty]
    public string EntityType { get => fields.EntityType[this]; set => fields.EntityType[this] = value; }

    [DisplayName("Entity Id"), Column("EntityID"), Size(255), NotNull]
    public string EntityId { get => fields.EntityId[this]; set => fields.EntityId[this] = value; }

    [DisplayName("Text"), NotNull]
    public string Text { get => fields.Text[this]; set => fields.Text[this] = value; }

    [DisplayName("Insert User Id"), NotNull, Insertable(false), Updatable(false)]
    public int? InsertUserId { get => fields.InsertUserId[this]; set => fields.InsertUserId[this] = value; }

    [DisplayName("Insert Date"), NotNull, Insertable(false), Updatable(false)]
    public DateTime? InsertDate { get => fields.InsertDate[this]; set => fields.InsertDate[this] = value; }

    [DisplayName("Insert User"), NotMapped]
    public string InsertUserDisplayName { get => fields.InsertUserDisplayName[this]; set => fields.InsertUserDisplayName[this] = value; }

    public Field InsertUserIdField => Fields.InsertUserId;

    public DateTimeField InsertDateField => Fields.InsertDate;

    public Field UpdateUserIdField => Fields.InsertUserId;

    public DateTimeField UpdateDateField => Fields.InsertDate;

    public class RowFields : RowFieldsBase
    {
        public Int64Field NoteId;
        public StringField EntityType;
        public StringField EntityId;
        public StringField Text;
        public Int32Field InsertUserId;
        public DateTimeField InsertDate;
        public StringField InsertUserDisplayName;


    }
}