namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("accountant.AccountingByTransaction")]
    public partial class AccountingByTransaction
    {
        [Key]
        [Column(Order = 0, TypeName = "date")]
        public DateTime AccountingDate { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TransactionId { get; set; }

        [Key]
        [Column(Order = 2)]
        public long AccountingByTransactionId { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(3)]
        public string CountryId { get; set; }

        public int CompanyId { get; set; }

        public long SequenceAccounting { get; set; }

        public int AccountingCodeId { get; set; }

        [Required]
        [StringLength(1)]
        public string Sign { get; set; }

        public decimal Amount { get; set; }

        [Column(TypeName = "date")]
        public DateTime MovementDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SendDateToSAP { get; set; }

        public short RecordStatusId { get; set; }

        public short RecordTypeId { get; set; }

        public int StoreId { get; set; }

        [Required]
        [StringLength(4)]
        public string InterfaceType { get; set; }

        public DateTime RecordTimeStamp { get; set; }

        public int? VendorId { get; set; }

        public int? PosId { get; set; }

        public long? InvoiceControlId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ProviderPaymentDate { get; set; }

        public virtual Country Country { get; set; }

        public virtual InvoiceControl InvoiceControl { get; set; }

        public virtual RecordStatu RecordStatu { get; set; }

        public virtual RecordType RecordType { get; set; }

        public virtual Vendor Vendor { get; set; }
    }
}
