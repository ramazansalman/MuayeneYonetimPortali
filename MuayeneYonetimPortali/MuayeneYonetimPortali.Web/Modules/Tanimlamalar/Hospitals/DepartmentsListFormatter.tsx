import { Decorators, EntityGrid, Formatter, Lookup } from '@serenity-is/corelib';
import { FormatterContext } from "@serenity-is/sleekgrid";
import { HospitalsColumns, HospitalsRow, HospitalsService, DepartmentsRow } from '../../ServerTypes/Tanimlamalar';
import { HospitalsDialog } from './HospitalsDialog';

let lookup: Lookup<DepartmentsRow>;
let promise: Promise<Lookup<DepartmentsRow>>;

@Decorators.registerFormatter('Tanimlamalar.Hospitals.DepartmentsListFormatter')
export class DepartmentsListFormatter implements Formatter {

    format(ctx: FormatterContext) {

        let idList = ctx.value as number[];
        if (!idList || !idList.length)
            return "";

        let byId = lookup?.itemById;
        if (byId) {
            return idList.map(id => {
                var dept = byId[id];
                return ctx.escape(dept == null ? id : dept.Name);
            }).join(", ");
        }

        promise ??= DepartmentsRow.getLookupAsync().then(l => {
            lookup = l;
            try {
                ctx.grid?.invalidate();
            }
            finally {
                lookup = null;
                promise = null;
            }
        }).catch(() => promise = null);

        return <i class="fa fa-spinner"></i>;
    }
}