import { Decorators } from "@serenity-is/corelib";

export enum Gender {
    Erkek = 1,
    Kadin = 2
}
Decorators.registerEnumType(Gender, 'MuayeneYonetimPortali.Tanimlamalar.Gender', 'Tanimlamalar.Gender');