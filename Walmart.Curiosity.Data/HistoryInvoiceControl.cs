namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("accountant.HistoryInvoiceControl")]
    public partial class HistoryInvoiceControl
    {
        [Key]
        [Column(Order = 0)]
        public long HistoryInvoiceControlId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long InvoiceControlId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long GroupId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short RecordTypeId { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short RecordStatusId { get; set; }

        [StringLength(20)]
        public string IPFrom { get; set; }

        [StringLength(50)]
        public string HostFrom { get; set; }

        [StringLength(15)]
        public string UserId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? HistoryDate { get; set; }

        public TimeSpan? HistoryTime { get; set; }

        public int? ErrorCode { get; set; }

        [StringLength(200)]
        public string ErrorDescription { get; set; }

        public bool? ReInvoiceStatus { get; set; }
    }
}
