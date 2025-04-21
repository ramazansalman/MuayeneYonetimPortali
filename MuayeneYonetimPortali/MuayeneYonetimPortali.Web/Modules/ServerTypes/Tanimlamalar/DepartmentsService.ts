import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { DepartmentsRow } from "./DepartmentsRow";

export namespace DepartmentsService {
    export const baseUrl = 'Tanimlamalar/Departments';

    export declare function Create(request: SaveRequest<DepartmentsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<DepartmentsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<DepartmentsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<DepartmentsRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<DepartmentsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<DepartmentsRow>>;

    export const Methods = {
        Create: "Tanimlamalar/Departments/Create",
        Update: "Tanimlamalar/Departments/Update",
        Delete: "Tanimlamalar/Departments/Delete",
        Retrieve: "Tanimlamalar/Departments/Retrieve",
        List: "Tanimlamalar/Departments/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>DepartmentsService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}