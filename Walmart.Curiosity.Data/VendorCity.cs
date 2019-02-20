namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VendorCity")]
    public partial class VendorCity
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VendorId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CityId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(3)]
        public string CountryId { get; set; }

        public virtual City City { get; set; }

        public virtual Vendor Vendor { get; set; }
    }
}
