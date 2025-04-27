import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { DiagnosesColumns, DiagnosesRow, DiagnosesService } from '../../ServerTypes/Tanimlamalar';
import { DiagnosesDialog } from './DiagnosesDialog';

@Decorators.registerClass('MuayeneYonetimPortali.Tanimlamalar.DiagnosesGrid')
export class DiagnosesGrid extends EntityGrid<DiagnosesRow> {
    protected getColumnsKey() { return DiagnosesColumns.columnsKey; }
    protected getDialogType() { return DiagnosesDialog; }
    protected getRowDefinition() { return DiagnosesRow; }
    protected getService() { return DiagnosesService.baseUrl; }
}