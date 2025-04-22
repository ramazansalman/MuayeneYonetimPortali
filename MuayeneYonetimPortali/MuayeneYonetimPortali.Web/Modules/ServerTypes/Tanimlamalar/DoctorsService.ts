import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { DoctorsRow } from "./DoctorsRow";

export namespace DoctorsService {
    export const baseUrl = 'Tanimlamalar/Doctors';

    export declare function Create(request: SaveRequest<DoctorsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<DoctorsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<DoctorsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<DoctorsRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<DoctorsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<DoctorsRow>>;

    export const Methods = {
        Create: "Tanimlamalar/Doctors/Create",
        Update: "Tanimlamalar/Doctors/Update",
        Delete: "Tanimlamalar/Doctors/Delete",
        Retrieve: "Tanimlamalar/Doctors/Retrieve",
        List: "Tanimlamalar/Doctors/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>DoctorsService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}