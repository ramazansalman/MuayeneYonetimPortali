import { confirmDialog, Decorators, EntityGrid, GridRowSelectionMixin, localText, notifyError, notifySuccess, notifyWarning, text, Toastr } from '@serenity-is/corelib';
import { PatientsColumns, PatientsRow, PatientsService } from '../../ServerTypes/Tanimlamalar';
import { PatientsDialog } from './PatientsDialog';

@Decorators.registerClass('MuayeneYonetimPortali.Tanimlamalar.PatientsGrid')
export class PatientsGrid extends EntityGrid<PatientsRow> {
    protected getColumnsKey() { return PatientsColumns.columnsKey; }
    protected getDialogType() { return PatientsDialog; }
    protected getRowDefinition() { return PatientsRow; }
    protected getService() { return PatientsService.baseUrl; }
    private rowSelection: GridRowSelectionMixin;
    protected createToolbarExtensions() {
        super.createToolbarExtensions();

        this.rowSelection = new GridRowSelectionMixin(this, {});
    }

    protected getColumns() {
        var columns = super.getColumns();

        var sc = GridRowSelectionMixin.createSelectColumn(() => this.rowSelection);
        sc.width = 30;
        columns.splice(0, 0, sc);
        return columns;
    }

    // protected override getButtons() {

    //     var self = this;

    //     var buttons = super.getButtons();

    //     buttons.push({
    //         cssClass: "add-button icon-tool-button",
    //         title: localText("Toplu Sil"),
    //         icon: "fa-trash-alt text-red",
    //         onClick: e => {

    //             let secilen = this.rowSelection.getSelectedAsInt32();
    //             //alert(secilen);
    //             secilen.forEach(element => {
    //                 PatientsService.Delete({EntityId:element
    //                 });
    //             });
    //             this.refresh();
    //     }});

    //     return buttons;
    // }

    protected override getButtons() {
        const buttons = super.getButtons();

        buttons.push({
            cssClass: "add-button icon-tool-button",
            title: localText("Toplu Sil"),
            icon: "fa-trash-alt text-red",
            onClick: () => {
                const selected = this.rowSelection.getSelectedAsInt32();

                if (selected.length === 0) {
                    notifyWarning("Lütfen silinecek kayıtları seçin.");
                    return;
                }

                confirmDialog(`${selected.length} kayıt silinecek. Emin misiniz?`, () => {
                    // Her silme işlemi bir Promise döner, hepsini toplayalım
                    const deletePromises = selected.map(id =>
                        PatientsService.Delete({ EntityId: id })
                    );

                    Promise.all(deletePromises).then(() => {
                        notifySuccess("Seçilen kayıtlar başarıyla silindi.");
                        this.refresh(); // hepsi tamamlandıktan sonra tabloyu yenile
                        this.rowSelection.clear();
                    }).catch(err => {
                        notifyError("Silme işlemi sırasında hata oluştu.");
                        console.error(err);
                    });
                });
            }
        });

        return buttons;
    }
}