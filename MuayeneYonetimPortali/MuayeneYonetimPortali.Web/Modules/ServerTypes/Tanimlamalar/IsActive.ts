import { Decorators } from "@serenity-is/corelib";

export enum IsActive {
    Pasif = 0,
    Aktif = 1,
    Silinmis = 2
}
Decorators.registerEnumType(IsActive, 'MuayeneYonetimPortali.Tanimlamalar.IsActive', 'Tanimlamalar.IsActive');