namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VendorUri")]
    public partial class VendorUri
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VendorId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short TransactionTypeId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(3)]
        public string CountryId { get; set; }

        [Required]
        [StringLength(500)]
        public string Uri { get; set; }

        [Required]
        [StringLength(10)]
        public string Bin { get; set; }

        public int TimeOut { get; set; }

        public short? RecordStatusId { get; set; }

        public virtual TransactionType TransactionType { get; set; }

        public virtual Vendor Vendor { get; set; }
    }
}
