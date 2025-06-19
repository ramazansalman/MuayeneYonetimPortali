import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { TwoFactorCodeRow } from "./TwoFactorCodeRow";

export namespace TwoFactorCodeService {
    export const baseUrl = 'Administration/TwoFactorCode';

    export declare function Create(request: SaveRequest<TwoFactorCodeRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<TwoFactorCodeRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<TwoFactorCodeRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<TwoFactorCodeRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<TwoFactorCodeRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<TwoFactorCodeRow>>;

    export const Methods = {
        Create: "Administration/TwoFactorCode/Create",
        Update: "Administration/TwoFactorCode/Update",
        Delete: "Administration/TwoFactorCode/Delete",
        Retrieve: "Administration/TwoFactorCode/Retrieve",
        List: "Administration/TwoFactorCode/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>TwoFactorCodeService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}