import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ExaminationsColumns, ExaminationsRow, ExaminationsService } from '../../ServerTypes/Examinations';
import { ExaminationsDialog } from './ExaminationsDialog';

@Decorators.registerClass('MuayeneYonetimPortali.Examinations.ExaminationsGrid')
export class ExaminationsGrid extends EntityGrid<ExaminationsRow> {
    protected getColumnsKey() { return ExaminationsColumns.columnsKey; }
    protected getDialogType() { return ExaminationsDialog; }
    protected getRowDefinition() { return ExaminationsRow; }
    protected getService() { return ExaminationsService.baseUrl; }
}