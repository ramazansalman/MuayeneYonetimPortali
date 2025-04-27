using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace MuayeneYonetimPortali.Prescriptions;

[ConnectionKey("Default"), Module("Prescriptions"), TableName("PrescriptionDrugs")]
[DisplayName("Prescription Drugs"), InstanceName("Prescription Drugs")]
[ReadPermission("Prescriptions.PrescriptionDrugs.General")]
[ModifyPermission("Prescriptions.PrescriptionDrugs.General")]
[ServiceLookupPermission("Prescriptions.PrescriptionDrugs.General")]
public sealed class PrescriptionDrugsRow : Row<PrescriptionDrugsRow.RowFields>, IIdRow, INameRow
{
    const string jPrescription = nameof(jPrescription);
    const string jDrug = nameof(jDrug);

    [DisplayName("Prescription Drug Id"), Identity, IdProperty]
    public int? PrescriptionDrugId { get => fields.PrescriptionDrugId[this]; set => fields.PrescriptionDrugId[this] = value; }

    [DisplayName("Prescription"), NotNull, ForeignKey("Prescriptions", "PrescriptionId"), LeftJoin(jPrescription)]
    [TextualField(nameof(PrescriptionNote))]
    public int? PrescriptionId { get => fields.PrescriptionId[this]; set => fields.PrescriptionId[this] = value; }

    [DisplayName("Drug"), NotNull, ForeignKey(typeof(Tanimlamalar.DrugsRow)), LeftJoin(jDrug), TextualField(nameof(DrugName))]
    [ServiceLookupEditor(typeof(Tanimlamalar.DrugsRow), Service = "Tanimlamalar/Drugs/List")]
    public int? DrugId { get => fields.DrugId[this]; set => fields.DrugId[this] = value; }

    [DisplayName("Usage"), Size(100), QuickSearch, NameProperty]
    public string Usage { get => fields.Usage[this]; set => fields.Usage[this] = value; }

    [DisplayName("Prescription Prescription Note"), Expression($"{jPrescription}.[PrescriptionNote]")]
    public string PrescriptionNote { get => fields.PrescriptionNote[this]; set => fields.PrescriptionNote[this] = value; }

    [DisplayName("Drug Name"), Origin(jDrug, nameof(Tanimlamalar.DrugsRow.Name))]
    public string DrugName { get => fields.DrugName[this]; set => fields.DrugName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field PrescriptionDrugId;
        public Int32Field PrescriptionId;
        public Int32Field DrugId;
        public StringField Usage;

        public StringField PrescriptionNote;
        public StringField DrugName;
    }
}