import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { HospitalsRow } from "./HospitalsRow";

export namespace HospitalsService {
    export const baseUrl = 'Tanimlamalar/Hospitals';

    export declare function Create(request: SaveRequest<HospitalsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<HospitalsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<HospitalsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<HospitalsRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<HospitalsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<HospitalsRow>>;

    export const Methods = {
        Create: "Tanimlamalar/Hospitals/Create",
        Update: "Tanimlamalar/Hospitals/Update",
        Delete: "Tanimlamalar/Hospitals/Delete",
        Retrieve: "Tanimlamalar/Hospitals/Retrieve",
        List: "Tanimlamalar/Hospitals/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>HospitalsService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}