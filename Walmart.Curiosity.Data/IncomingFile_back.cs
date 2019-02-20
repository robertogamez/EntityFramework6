namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("income.IncomingFile_back")]
    public partial class IncomingFile_back
    {
        [Key]
        [Column(Order = 0, TypeName = "date")]
        public DateTime TrDate { get; set; }

        [Key]
        [Column(Order = 1)]
        public long IncomingFileId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(3)]
        public string CountryId { get; set; }

        public int StoreId { get; set; }

        public int? BrokerId { get; set; }

        public int VendorId { get; set; }

        [Required]
        [StringLength(6)]
        public string VendorIncommingId { get; set; }

        public decimal? Amount { get; set; }

        public short? RecordStatusId { get; set; }

        public short? RecordTypeId { get; set; }

        public DateTime TrDateTime { get; set; }

        [StringLength(100)]
        public string MainChain { get; set; }

        public int? PosId { get; set; }

        public bool? CreateIncomeFile { get; set; }

        public virtual Country Country { get; set; }

        public virtual RecordStatu RecordStatu { get; set; }

        public virtual RecordType RecordType { get; set; }

        public virtual Vendor Vendor { get; set; }
    }
}
