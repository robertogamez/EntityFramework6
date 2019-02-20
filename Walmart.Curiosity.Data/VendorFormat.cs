namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VendorFormat")]
    public partial class VendorFormat
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VendorId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FormatId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(3)]
        public string CountryId { get; set; }

        [StringLength(20)]
        public string MasterVendor { get; set; }

        [StringLength(20)]
        public string ArticleNumber { get; set; }

        [StringLength(20)]
        public string Department { get; set; }

        public virtual Format Format { get; set; }

        public virtual Vendor Vendor { get; set; }
    }
}
