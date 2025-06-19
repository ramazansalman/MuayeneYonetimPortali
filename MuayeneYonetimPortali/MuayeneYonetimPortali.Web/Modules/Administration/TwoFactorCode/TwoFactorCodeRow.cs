using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace MuayeneYonetimPortali.Administration;

[ConnectionKey("Default"), Module("Administration"), TableName("TwoFactorCode")]
[DisplayName("Two Factor Code"), InstanceName("Two Factor Code")]
[ReadPermission("Administration:TwoFactorCode")]
[ModifyPermission("Administration:TwoFactorCode")]
[ServiceLookupPermission("Administration:TwoFactorCode")]
public sealed class TwoFactorCodeRow : Row<TwoFactorCodeRow.RowFields>, IIdRow, INameRow
{
    const string jUser = nameof(jUser);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("User"), NotNull, ForeignKey(typeof(UserRow)), LeftJoin(jUser), TextualField(nameof(Username))]
    [LookupEditor(typeof(UserRow), Async = true)]
    public int? UserId { get => fields.UserId[this]; set => fields.UserId[this] = value; }

    [DisplayName("Code"), Size(10), NotNull, QuickSearch, NameProperty]
    public string Code { get => fields.Code[this]; set => fields.Code[this] = value; }

    [DisplayName("Expire Time"), NotNull]
    public DateTime? ExpireTime { get => fields.ExpireTime[this]; set => fields.ExpireTime[this] = value; }

    [DisplayName("User Username"), Origin(jUser, nameof(UserRow.Username))]
    public string Username { get => fields.Username[this]; set => fields.Username[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public Int32Field UserId;
        public StringField Code;
        public DateTimeField ExpireTime;

        public StringField Username;
    }
}