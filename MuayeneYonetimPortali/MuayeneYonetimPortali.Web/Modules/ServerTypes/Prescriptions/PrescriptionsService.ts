import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { PrescriptionsRow } from "./PrescriptionsRow";

export namespace PrescriptionsService {
    export const baseUrl = 'Prescriptions/Prescriptions';

    export declare function Create(request: SaveRequest<PrescriptionsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<PrescriptionsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<PrescriptionsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<PrescriptionsRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<PrescriptionsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<PrescriptionsRow>>;

    export const Methods = {
        Create: "Prescriptions/Prescriptions/Create",
        Update: "Prescriptions/Prescriptions/Update",
        Delete: "Prescriptions/Prescriptions/Delete",
        Retrieve: "Prescriptions/Prescriptions/Retrieve",
        List: "Prescriptions/Prescriptions/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>PrescriptionsService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}