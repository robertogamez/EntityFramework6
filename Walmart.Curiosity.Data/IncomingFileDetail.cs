namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("income.IncomingFileDetail")]
    public partial class IncomingFileDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TransactionId { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime TrDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime FileDate { get; set; }

        public DateTime FileDateTime { get; set; }

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

        public int? CreateIncomeFile { get; set; }

        public long? IncomingRegisterId { get; set; }
    }
}
