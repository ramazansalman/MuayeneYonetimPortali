import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { DrugsRow } from "./DrugsRow";

export namespace DrugsService {
    export const baseUrl = 'Tanimlamalar/Drugs';

    export declare function Create(request: SaveRequest<DrugsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<DrugsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<DrugsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<DrugsRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<DrugsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<DrugsRow>>;

    export const Methods = {
        Create: "Tanimlamalar/Drugs/Create",
        Update: "Tanimlamalar/Drugs/Update",
        Delete: "Tanimlamalar/Drugs/Delete",
        Retrieve: "Tanimlamalar/Drugs/Retrieve",
        List: "Tanimlamalar/Drugs/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>DrugsService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}