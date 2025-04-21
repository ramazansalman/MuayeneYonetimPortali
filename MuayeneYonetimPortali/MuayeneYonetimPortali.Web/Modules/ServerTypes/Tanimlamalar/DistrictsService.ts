import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { DistrictsRow } from "./DistrictsRow";

export namespace DistrictsService {
    export const baseUrl = 'Tanimlamalar/Districts';

    export declare function Create(request: SaveRequest<DistrictsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<DistrictsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<DistrictsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<DistrictsRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<DistrictsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<DistrictsRow>>;

    export const Methods = {
        Create: "Tanimlamalar/Districts/Create",
        Update: "Tanimlamalar/Districts/Update",
        Delete: "Tanimlamalar/Districts/Delete",
        Retrieve: "Tanimlamalar/Districts/Retrieve",
        List: "Tanimlamalar/Districts/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>DistrictsService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}