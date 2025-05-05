import { Decorators, EntityGrid, SubDialogHelper } from '@serenity-is/corelib';
import { AppointmentsColumns, AppointmentsRow, AppointmentsService } from '../../ServerTypes/Appointments';
import { AppointmentsDialog } from './AppointmentsDialog';
import { Column } from '@serenity-is/sleekgrid';

const fld = AppointmentsRow.Fields;

@Decorators.registerClass('MuayeneYonetimPortali.Appointments.AppointmentsGrid')
export class PatientAppointmentsGrid extends EntityGrid<AppointmentsRow> {
    protected getColumnsKey() { return AppointmentsColumns.columnsKey; }
    protected getDialogType() { return AppointmentsDialog; }
    protected getRowDefinition() { return AppointmentsRow; }
    protected getService() { return AppointmentsService.baseUrl; }

    // istediğin kolonları gizleyebilirsin
    // Varsayılan kolon listesi alınır ve ardından PatientFullName (hasta adı soyadı) 
    // alanı bu listeden çıkarılır. Bu, hastanın adı zaten sabit olduğu için, gride 
    // tekrar yazılmasını engeller.
    protected getColumns(): Column[] {
        return super.getColumns().filter(x => x.field !== fld.PatientFullName);
    }

    // iç içe açılma diyalog altında açılır
    // Dialog açıldığında, o dialogun hangi üst pencereye (parent dialog) ait olduğunu belirler.
    // SubDialogHelper.cascade çağrısı, bu gridin başka bir dialog içinden (örneğin hasta detay ekranı) açıldığını belirtir.
    // Bu sayede "dialog içinde dialog" açılması düzgün çalışır.
    protected initEntityDialog(itemType, dialog) {
        super.initEntityDialog(itemType, dialog);
        SubDialogHelper.cascade(dialog, this.domNode.closest('.ui-dialog') as HTMLElement);
    }

    // patientID burada gridin filtreleme koşuludur.
    // Dışarıdan bir hasta ID’si atanırsa:
    // this.setEquality(fld.PatientId, value) → Gridde sadece bu hastaya ait randevular listelenir.
    // this.refresh() → Grid yeniden yüklenir.
    // this.updateInterface() → Grid arayüzü güncellenir.
    declare private _patientID: number;

    // patienidnin get seti alındı
    get patientID() {
        return this._patientID;
    }

    set patientID(value: number) {
        if (this._patientID !== value) {
            this._patientID = value;
            this.setEquality(fld.PatientId, value);
            this.refresh();
            this.updateInterface();
        }
    }

    // patient id yoksa add buton ekleme
    // Griddeki butonları alır (Yeni, Sil, Dışa Aktar gibi).
    // Yeni (Add) butonunu bulur ve sadece patientID varsa aktif olmasını sağlar.
    // Yani: Hasta seçilmeden randevu eklenemez.
    protected override getButtons() {
        var buttons = super.getButtons();
        var addButton = buttons.find(x => x.action === 'add');
        if (addButton)
            addButton.disabled = () => !this._patientID;
        return buttons;
    }

    // new butonuna tıklayınca patientid yı otomatik doldurma
    // Yeni butonuna tıklanınca ne yapılacağını belirler.
    // Eğer hasta ID’si yoksa, hiçbir şey yapılmaz.
    // Varsa, AppointmentsDialog açılır ve PatientId alanı otomatik olarak doldurulur.
    protected addButtonClick() {
        if (!this.patientID)
            return;
        this.editItem({ PatientId: this._patientID });
    }

    // başlığı siliyor
    // Grid başlığını (header title) tamamen kaldırır.
    // Bu sayede, bu grid bir başka sayfada/sekmede gömülü kullanılıyorsa, ekstra başlık gösterilmez.
    protected getInitialTitle() {
        return null;
    }

    // patientid dolu değilse grid yükleme
    // Gridin veri yükleyip yüklemeyeceğini kontrol eder.
    // Eğer patientID tanımlı değilse, grid veri çekmez.
    protected getGridCanLoad() {
        return super.getGridCanLoad() && !!this.patientID;
    }
}