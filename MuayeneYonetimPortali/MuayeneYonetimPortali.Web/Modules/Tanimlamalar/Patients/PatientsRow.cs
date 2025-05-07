using MuayeneYonetimPortali.Note;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace MuayeneYonetimPortali.Tanimlamalar;

[ConnectionKey("Default"), Module("Tanimlamalar"), TableName("Patients")]
[DisplayName("Patients"), InstanceName("Patients")]
[ReadPermission("Tanimlamalar.Patients.General")]
[ModifyPermission("Tanimlamalar.Patients.General")]
[ServiceLookupPermission("Tanimlamalar.Patients.General")]
public sealed class PatientsRow : Row<PatientsRow.RowFields>, IIdRow, INameRow
{
    const string jUser = nameof(jUser);

    [DisplayName("Patient Id"), Identity, IdProperty]
    public int? PatientId { get => fields.PatientId[this]; set => fields.PatientId[this] = value; }

    [DisplayName("User"), NotNull, ForeignKey(typeof(Administration.UserRow)), LeftJoin(jUser), TextualField(nameof(Username))]
    [LookupEditor(typeof(Administration.UserRow), Async = true)]
    public int? UserId { get => fields.UserId[this]; set => fields.UserId[this] = value; }

    [DisplayName("Name"), Size(200), NotNull, QuickSearch, NameProperty]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    [DisplayName("Surname"), Size(200), NotNull]
    public string Surname { get => fields.Surname[this]; set => fields.Surname[this] = value; }

    [DisplayName("Gender"), NotNull]
    public Gender? Gender { get => fields.Gender[this]; set => fields.Gender[this] = value; }

    [DisplayName("Birth Date"), NotNull]
    public DateTime? BirthDate { get => fields.BirthDate[this]; set => fields.BirthDate[this] = value; }

    [DisplayName("Phone"), Size(20), NotNull]
    public string Phone { get => fields.Phone[this]; set => fields.Phone[this] = value; }

    [DisplayName("Email"), Size(100)]
    public string Email { get => fields.Email[this]; set => fields.Email[this] = value; }

    [DisplayName("Tckn"), Column("TCKN"), Size(11), NotNull]
    public string Tckn { get => fields.Tckn[this]; set => fields.Tckn[this] = value; }

    [DisplayName("User Username"), Origin(jUser, nameof(Administration.UserRow.Username))]
    public string Username { get => fields.Username[this]; set => fields.Username[this] = value; }

    [NotesEditor, NotMapped]
    public List<NoteRow> NoteList { get => fields.NoteList[this]; set => fields.NoteList[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field PatientId;
        public Int32Field UserId;
        public StringField Name;
        public StringField Surname;
        public EnumField<Gender> Gender;
        public DateTimeField BirthDate;
        public StringField Phone;
        public StringField Email;
        public StringField Tckn;

        public StringField Username;
        public RowListField<NoteRow> NoteList;

    }
}