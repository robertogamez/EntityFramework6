namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TransactionSummary20180402
    {
        [Key]
        [Column(Order = 0, TypeName = "date")]
        public DateTime TrDate { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TransactionId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(3)]
        public string CountryId { get; set; }

        [StringLength(25)]
        public string IpWcfCore { get; set; }

        public DateTime? WCFReceiveDateTime { get; set; }

        public int? VendorId { get; set; }

        [StringLength(2000)]
        public string RequestClient { get; set; }

        [StringLength(2000)]
        public string ResponseClient { get; set; }

        [StringLength(2000)]
        public string RequestVendor { get; set; }

        [StringLength(2000)]
        public string ResponseVendor { get; set; }

        public bool? isSuccess { get; set; }

        [StringLength(100)]
        public string ErrorType { get; set; }

        public int? CoreElapsedTime { get; set; }

        public int? TotalElapsedTime { get; set; }

        public int? VendorElapsedTime { get; set; }

        [StringLength(3000)]
        public string ErrorDescription { get; set; }

        [StringLength(3000)]
        public string DescResponseVendor { get; set; }

        [StringLength(10)]
        public string CodeResponseVendor { get; set; }

        public short? TransactionTypeId { get; set; }

        public short? RecordStatusId { get; set; }

        public bool? IsOnline { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime TrDateTime { get; set; }

        public bool? TimeOutFlag { get; set; }

        public short? AttemptsToReverse { get; set; }

        public int? StoreId { get; set; }

        public TimeSpan? TransactionTime { get; set; }

        [StringLength(10)]
        public string TerminalNumber { get; set; }

        [StringLength(10)]
        public string CashierNumber { get; set; }

        [StringLength(60)]
        public string ServiceReference { get; set; }

        public decimal? Amount { get; set; }

        [StringLength(1)]
        public string EntryMode { get; set; }

        [StringLength(3)]
        public string PaymentType { get; set; }

        [StringLength(10)]
        public string PosTrId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TrDateOriginal { get; set; }

        [Column(TypeName = "date")]
        public DateTime? VendorSendDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SendDateToJournal { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SendDateToProvider { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SendDateToMart { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(10)]
        public string Origen { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string UserID { get; set; }
    }
}
