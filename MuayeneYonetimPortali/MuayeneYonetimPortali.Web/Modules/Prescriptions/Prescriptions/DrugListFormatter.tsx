import { Decorators, Formatter, Lookup } from "@serenity-is/corelib";
import { FormatterContext } from "@serenity-is/sleekgrid";
import { DrugsRow } from "../../ServerTypes/Tanimlamalar/DrugsRow";

let lookup: Lookup<DrugsRow>;
let promise: Promise<Lookup<DrugsRow>>;

@Decorators.registerFormatter('MuayeneYonetimPortali.DrugListFormatter')
export class DrugListFormatter implements Formatter {

    format(ctx: FormatterContext) {

        let idList = ctx.value as number[];
        if (!idList || !idList.length)
            return "";

        let byId = lookup?.itemById;
        if (byId) {
            return idList.map(id => {
                var drug = byId[id];
                return ctx.escape(drug == null ? id : drug.Name);
            }).join(", ");
        }

        promise ??= DrugsRow.getLookupAsync().then(l => {
            lookup = l;
            try {
                ctx.grid?.invalidate();
            }
            finally {
                lookup = null;
                promise = null;
            }
        }).catch(() => promise = null);

        return `<i class="fa fa-spinner"></i>`;
    }
}