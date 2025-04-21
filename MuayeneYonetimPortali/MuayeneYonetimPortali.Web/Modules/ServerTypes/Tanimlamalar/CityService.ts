import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { CityRow } from "./CityRow";

export namespace CityService {
    export const baseUrl = 'Tanimlamalar/City';

    export declare function Create(request: SaveRequest<CityRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<CityRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<CityRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<CityRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<CityRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<CityRow>>;

    export const Methods = {
        Create: "Tanimlamalar/City/Create",
        Update: "Tanimlamalar/City/Update",
        Delete: "Tanimlamalar/City/Delete",
        Retrieve: "Tanimlamalar/City/Retrieve",
        List: "Tanimlamalar/City/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>CityService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}