import { fieldsProxy } from "@serenity-is/corelib";

export interface NoteRow {
    NoteId?: number;
    EntityType?: string;
    EntityId?: string;
    Text?: string;
    InsertUserId?: number;
    InsertDate?: string;
    InsertUserDisplayName?: string;
}

export abstract class NoteRow {
    static readonly idProperty = 'NoteId';
    static readonly nameProperty = 'EntityType';
    static readonly localTextPrefix = 'Note.Note';
    static readonly deletePermission = 'Note.General';
    static readonly insertPermission = 'Note.General';
    static readonly readPermission = 'Note.General';
    static readonly updatePermission = 'Note.General';

    static readonly Fields = fieldsProxy<NoteRow>();
}