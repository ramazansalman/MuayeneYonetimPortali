import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { HospitalDepartmentsRow } from "./HospitalDepartmentsRow";

export namespace HospitalDepartmentsService {
    export const baseUrl = 'Tanimlamalar/HospitalDepartments';

    export declare function Create(request: SaveRequest<HospitalDepartmentsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<HospitalDepartmentsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<HospitalDepartmentsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<HospitalDepartmentsRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<HospitalDepartmentsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<HospitalDepartmentsRow>>;

    export const Methods = {
        Create: "Tanimlamalar/HospitalDepartments/Create",
        Update: "Tanimlamalar/HospitalDepartments/Update",
        Delete: "Tanimlamalar/HospitalDepartments/Delete",
        Retrieve: "Tanimlamalar/HospitalDepartments/Retrieve",
        List: "Tanimlamalar/HospitalDepartments/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>HospitalDepartmentsService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}