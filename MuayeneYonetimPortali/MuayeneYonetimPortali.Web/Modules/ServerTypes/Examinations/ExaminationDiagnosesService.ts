import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { ExaminationDiagnosesRow } from "./ExaminationDiagnosesRow";

export namespace ExaminationDiagnosesService {
    export const baseUrl = 'Examinations/ExaminationDiagnoses';

    export declare function Create(request: SaveRequest<ExaminationDiagnosesRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<ExaminationDiagnosesRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ExaminationDiagnosesRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<ExaminationDiagnosesRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ExaminationDiagnosesRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<ExaminationDiagnosesRow>>;

    export const Methods = {
        Create: "Examinations/ExaminationDiagnoses/Create",
        Update: "Examinations/ExaminationDiagnoses/Update",
        Delete: "Examinations/ExaminationDiagnoses/Delete",
        Retrieve: "Examinations/ExaminationDiagnoses/Retrieve",
        List: "Examinations/ExaminationDiagnoses/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>ExaminationDiagnosesService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}