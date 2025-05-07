import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { NoteRow } from "./NoteRow";

export namespace NoteService {
    export const baseUrl = 'Note/Note';

    export declare function Create(request: SaveRequest<NoteRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<NoteRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<NoteRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<NoteRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<NoteRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<NoteRow>>;

    export const Methods = {
        Create: "Note/Note/Create",
        Update: "Note/Note/Update",
        Delete: "Note/Note/Delete",
        Retrieve: "Note/Note/Retrieve",
        List: "Note/Note/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>NoteService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}