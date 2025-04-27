import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { DiagnosesRow } from "./DiagnosesRow";

export namespace DiagnosesService {
    export const baseUrl = 'Tanimlamalar/Diagnoses';

    export declare function Create(request: SaveRequest<DiagnosesRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<DiagnosesRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<DiagnosesRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<DiagnosesRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<DiagnosesRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<DiagnosesRow>>;

    export const Methods = {
        Create: "Tanimlamalar/Diagnoses/Create",
        Update: "Tanimlamalar/Diagnoses/Update",
        Delete: "Tanimlamalar/Diagnoses/Delete",
        Retrieve: "Tanimlamalar/Diagnoses/Retrieve",
        List: "Tanimlamalar/Diagnoses/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>DiagnosesService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}