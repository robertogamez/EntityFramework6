namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("accountant.Commission")]
    public partial class Commission
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

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VendorCommissionId { get; set; }

        public int VendorId { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(1)]
        public string Sign { get; set; }

        public decimal Value { get; set; }

        public decimal Iva { get; set; }

        public TimeSpan TrTime { get; set; }

        public short? RecordTypeId { get; set; }

        public short? RecordStatusId { get; set; }

        public DateTime CreationDate { get; set; }

        [Required]
        [StringLength(20)]
        public string CreatedByUser { get; set; }

        public DateTime UpdatedDate { get; set; }

        [Required]
        [StringLength(20)]
        public string UpdatedByUser { get; set; }

        public decimal Total { get; set; }

        public long? CuriosityInvoiceNumber { get; set; }

        public virtual Country Country { get; set; }

        public virtual RecordStatu RecordStatu { get; set; }

        public virtual RecordType RecordType { get; set; }

        public virtual VendorCommission VendorCommission { get; set; }
    }
}
