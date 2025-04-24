import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { AppointmentsRow } from "./AppointmentsRow";

export namespace AppointmentsService {
    export const baseUrl = 'Appointments/Appointments';

    export declare function Create(request: SaveRequest<AppointmentsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<AppointmentsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<AppointmentsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<AppointmentsRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<AppointmentsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<AppointmentsRow>>;

    export const Methods = {
        Create: "Appointments/Appointments/Create",
        Update: "Appointments/Appointments/Update",
        Delete: "Appointments/Appointments/Delete",
        Retrieve: "Appointments/Appointments/Retrieve",
        List: "Appointments/Appointments/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>AppointmentsService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}