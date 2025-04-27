import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { ExaminationsRow } from "./ExaminationsRow";

export namespace ExaminationsService {
    export const baseUrl = 'Examinations/Examinations';

    export declare function Create(request: SaveRequest<ExaminationsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<ExaminationsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ExaminationsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<ExaminationsRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ExaminationsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<ExaminationsRow>>;

    export const Methods = {
        Create: "Examinations/Examinations/Create",
        Update: "Examinations/Examinations/Update",
        Delete: "Examinations/Examinations/Delete",
        Retrieve: "Examinations/Examinations/Retrieve",
        List: "Examinations/Examinations/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>ExaminationsService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}