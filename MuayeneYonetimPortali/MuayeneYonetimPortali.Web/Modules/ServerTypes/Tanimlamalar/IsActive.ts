import { Decorators } from "@serenity-is/corelib";

export enum IsActive {
    Silinmis = -1,
    Pasif = 0,
    Aktif = 1
}
Decorators.registerEnumType(IsActive, 'MuayeneYonetimPortali.Tanimlamalar.IsActive', 'Tanimlamalar.Enums.IsActive');