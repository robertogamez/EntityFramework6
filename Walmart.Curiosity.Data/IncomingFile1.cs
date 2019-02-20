namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("income.IncomingFile")]
    public partial class IncomingFile1
    {
        [Key]
        [Column(Order = 0, TypeName = "date")]
        public DateTime TrDate { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime FileDate { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime FileDateTime { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ReassignedDate { get; set; }

        [StringLength(6)]
        public string IncomeRowId { get; set; }

        [StringLength(6)]
        public string IncomeLockerId { get; set; }

        [StringLength(6)]
        public string IncomeKeyId { get; set; }

        [StringLength(3)]
        public string CountryId { get; set; }

        public int? CompanyId { get; set; }

        public short? BusinessId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoreId { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(6)]
        public string VendorIncommingId { get; set; }

        public decimal? Amount { get; set; }

        public decimal? SentAmount { get; set; }

        public short? RecordStatusId { get; set; }

        public int? CreateIncomeFile { get; set; }

        public long? IncomingRegisterId { get; set; }
    }
}
