namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("accountant.InvoiceControl")]
    public partial class InvoiceControl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InvoiceControl()
        {
            Accountings = new HashSet<Accounting>();
            AccountingByTransactions = new HashSet<AccountingByTransaction>();
        }

        [Key]
        [Column(Order = 0)]
        public long InvoiceControlId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string CountryId { get; set; }

        public long CuriosityInvoiceNumber { get; set; }

        public int? VendorId { get; set; }

        public int? BrokerId { get; set; }

        public int? CompanyId { get; set; }

        [StringLength(3)]
        public string PaymentTypeProviderId { get; set; }

        public byte? InvoiceMonth { get; set; }

        public short? InvoiceYear { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateInvoiceInit { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateInvoiceEnd { get; set; }

        [StringLength(20)]
        public string InvoiceSerie { get; set; }

        public int? InvoiceFolio { get; set; }

        [StringLength(100)]
        public string FolioFiscal { get; set; }

        public int? Quantity { get; set; }

        [StringLength(500)]
        public string InvoiceConcept { get; set; }

        public decimal? UnitValue { get; set; }

        public decimal? Amount { get; set; }

        public int? Iva { get; set; }

        public decimal? IvaAmount { get; set; }

        public decimal? DiscountAmount { get; set; }

        public decimal? SubTotalAmount { get; set; }

        public decimal? TotalAmount { get; set; }

        public DateTime InvoiceCreationDate { get; set; }

        [Required]
        [StringLength(20)]
        public string InvoiceCreatedByUser { get; set; }

        public DateTime? InvoiceSendDate { get; set; }

        [StringLength(30)]
        public string InvoiceGenerationDateStr { get; set; }

        [StringLength(20)]
        public string InvoiceGeneratedByUser { get; set; }

        public DateTime? ReInvoiceCreationDate { get; set; }

        [StringLength(20)]
        public string ReInvoiceCreatedByUser { get; set; }

        [StringLength(100)]
        public string ReInvoiceCreatedReason { get; set; }

        public DateTime? InvoiceCancelationDate { get; set; }

        [StringLength(20)]
        public string InvoiceCancelatedByUser { get; set; }

        [StringLength(100)]
        public string InvoiceCancelationReason { get; set; }

        [StringLength(20)]
        public string InvoiceSource { get; set; }

        [StringLength(40)]
        public string IdTransaction { get; set; }

        [StringLength(100)]
        public string InvoiceObservation { get; set; }

        public short? RecordTypeId { get; set; }

        public short? RecordStatusId { get; set; }

        public DateTime IcTimeStamp { get; set; }

        public DateTime UpdatedDate { get; set; }

        [Required]
        [StringLength(20)]
        public string UpdatedByUser { get; set; }

        public int? ErrorCode { get; set; }

        [StringLength(200)]
        public string ErrorDescription { get; set; }

        public long? InvoiceControlIdToApply { get; set; }

        [StringLength(20)]
        public string InvoiceSerieOriginal { get; set; }

        [StringLength(20)]
        public string InvoiceFolioOriginal { get; set; }

        [Column("UUIDOriginal ")]
        [StringLength(100)]
        public string UUIDOriginal_ { get; set; }

        public bool? AccountingStatus { get; set; }

        public bool? InterfaceStatus { get; set; }

        public bool? CreditNoteStatus { get; set; }

        public long? GroupId { get; set; }

        public bool? RefacturadaStatus { get; set; }

        public bool? AccountedInvoice { get; set; }

        public bool? AccountedCancellation { get; set; }

        public short? AccountedStatusId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Accounting> Accountings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountingByTransaction> AccountingByTransactions { get; set; }

        public virtual Broker Broker { get; set; }

        public virtual Company Company { get; set; }

        public virtual Country Country { get; set; }

        public virtual PaymentTypeProvider PaymentTypeProvider { get; set; }

        public virtual RecordStatu RecordStatu { get; set; }

        public virtual RecordType RecordType { get; set; }

        public virtual Vendor Vendor { get; set; }
    }
}
