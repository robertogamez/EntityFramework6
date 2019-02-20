namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FormatConversionByVendor")]
    public partial class FormatConversionByVendor
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VendorId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string CountryId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FormatId { get; set; }

        [Required]
        [StringLength(20)]
        public string FormatConvertedId { get; set; }

        public virtual Country Country { get; set; }

        public virtual Format Format { get; set; }

        public virtual Vendor Vendor { get; set; }
    }
}
