import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { PrescriptionDrugsRow } from "./PrescriptionDrugsRow";

export namespace PrescriptionDrugsService {
    export const baseUrl = 'Prescriptions/PrescriptionDrugs';

    export declare function Create(request: SaveRequest<PrescriptionDrugsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<PrescriptionDrugsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<PrescriptionDrugsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<PrescriptionDrugsRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<PrescriptionDrugsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<PrescriptionDrugsRow>>;

    export const Methods = {
        Create: "Prescriptions/PrescriptionDrugs/Create",
        Update: "Prescriptions/PrescriptionDrugs/Update",
        Delete: "Prescriptions/PrescriptionDrugs/Delete",
        Retrieve: "Prescriptions/PrescriptionDrugs/Retrieve",
        List: "Prescriptions/PrescriptionDrugs/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>PrescriptionDrugsService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}