﻿import { Decorators, EntityDialog, TabsExtensions, WidgetProps } from '@serenity-is/corelib';
import { PatientsForm, PatientsRow, PatientsService } from '../../ServerTypes/Tanimlamalar';
import { PatientAppointmentsGrid } from '../../Appointments/Appointments/PatientAppointmentsGrid';
import { PatientExaminationsGrid } from '../../Examinations/Examinations/PatientExaminationsGrid';

@Decorators.registerClass('MuayeneYonetimPortali.Tanimlamalar.PatientsDialog')
export class PatientsDialog<P = {}> extends EntityDialog<PatientsRow, P> {
    protected getFormKey() { return PatientsForm.formKey; }
    protected getRowDefinition() { return PatientsRow; }
    protected getService() { return PatientsService.baseUrl; }

    protected form = new PatientsForm(this.idPrefix);

    // Bu satır, PatientsDialog sınıfına ait bir özellik (property) tanımlar.
    // appointmentsGrid, tip olarak PatientAppointmentsGrid sınıfından bir grid bileşeni olacak.
    // Bu grid, daha sonra ref özelliği ile renderContents() içinde atanacaktır (bak: JSX kısmı).
    // Yani: Bu, hastaya ait randevuları listeleyen gridin referansını tutar.
    declare private appointmentsGrid: PatientAppointmentsGrid;
    declare private examinationsGrid: PatientExaminationsGrid;

    constructor(props: WidgetProps<any>) {
        super(props);

        this.byId('NoteList').closest('.field').hide();
        this.byId('NoteList').appendTo(this.byId('TabNotes'));
    }


    // loadEntity, diyalog içine bir kayıt (örneğin bir hasta) yüklendiğinde çağrılır.
    // super.loadEntity(entity) → Üst sınıfın (EntityDialog) normal yükleme davranışını çağırır.
    // TabsExtensions.setDisabled(...) → Eğer hasta kaydı yeni oluşturuluyorsa veya silinmişse, 
    // "Hasta Randevu" sekmesini pasifleştirir (kullanıcı erişemez).
    // this.appointmentsGrid.patientID = entity.PatientId → Alt grid'e hasta ID'sini aktarır. 
    // Böylece sadece o hastaya ait randevular listelenir.
    loadEntity(entity: PatientsRow) {
        super.loadEntity(entity);

        TabsExtensions.setDisabled(this.tabs, 'Randevular', this.isNewOrDeleted());
        TabsExtensions.setDisabled(this.tabs, 'Muayeneler', this.isNewOrDeleted());
        TabsExtensions.setDisabled(this.tabs, 'Notes', this.isNewOrDeleted());


        this.appointmentsGrid.patientID = entity.PatientId;
        this.examinationsGrid.patientID = entity.PatientId;
    }

    //üste yeni tab açıp tab isimleri veriliyor. istenilen grid çağırılıyor ve tab içinde bu grid geliyor.
    // const id = this.useIdPrefix();
    // Dialog’a özel bir id prefix üretir. Böylece aynı sayfada birden fazla dialog açıldığında çakışma yaşanmaz.
    // Örnek: TabHasta, TabRandevular, Form, Toolbar gibi element id’lerini güvenli hale getirir.
    //
    // <ul>...</ul> — Sekme Başlıkları
    // Dialog’un üst kısmındaki sekmeleri tanımlar.
    // "Hasta" → Form alanlarının bulunduğu sekmedir.
    // "Hasta Randevu" → Alt grid'in (appointments) bulunduğu sekmedir.
    //
    // <div id={id.TabHasta}>...</div>
    // Bu sekme altında hasta bilgileri (adı, doğum tarihi vs.) girilir.
    // PropertyGrid bu alanları otomatik oluşturur.
    // Toolbar kısmı ek butonlar için ayrılmıştır (şu an boş).
    //
    // <div id={id.TabRandevular}>...</div>
    // Hasta randevularını gösteren grid burada yer alır.
    // ref={grid => ...}:
    // Grid bileşeni oluşturulduğunda this.appointmentsGrid alanına referans atanır.
    // Böylece grid'e programatik erişim mümkün olur (örneğin: hasta id gönderme).
    // openDialogsAsPanel = false:
    // Alt grid içinde yeni randevu eklenirse popup dialog olarak açılsın.
    // true olsaydı sayfanın sağında panel gibi açılırdı.
    //
    renderContents(): any {
        const id = this.useIdPrefix();
        return (
            <div id={id.Tabs} class="s-DialogContent">
                <ul>
                    <li><a href={'#' + id.TabHasta}><span>{"Hasta"}</span></a></li>
                    <li><a href={'#' + id.TabRandevular}><span>{"Hasta Randevu"}</span></a></li>
                    <li><a href={'#' + id.TabMuayeneler}><span>{"Muayeneler"}</span></a></li>
                    {/* <li><a href={'#' + id.TabNotes}><span>{localText("Db.Northwind.Note.EntityPlural")}</span></a></li> */}
                    <li><a href={'#' + id.TabNotes}><span>{"Notlar"}</span></a></li>

                </ul>
                <div id={id.TabHasta} class="tab-pane s-TabHasta">
                    <div id={id.Toolbar} class="s-DialogToolbar">
                    </div>
                    <form id={id.Form} action="" class="s-Form">
                        <div id={id.PropertyGrid}></div>
                    </form>
                </div>
                <div id={id.TabRandevular} class="tab-pane s-TabRandevular">
                <PatientAppointmentsGrid id={id.PatientAppointmentsGrid} ref={grid => {
                        this.appointmentsGrid = grid;
                        this.appointmentsGrid.openDialogsAsPanel = false;
                    }} />
                </div>
                <div id={id.TabMuayeneler} class="tab-pane s-TabMuayeneler">
                <PatientExaminationsGrid id={id.PatientExaminationsGrid} ref={grid => {
                        this.examinationsGrid = grid;
                        this.examinationsGrid.openDialogsAsPanel = false;
                    }} />
                </div>
                <div id={id.TabNotes} class="tab-pane s-TabNotes">
                </div>
            </div>
        )
    }
}