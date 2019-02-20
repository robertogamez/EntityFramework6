namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LineasCaptura")]
    public partial class LineasCaptura
    {
        [Key]
        [StringLength(12)]
        public string Prefix { get; set; }

        public int PrefixConceptId { get; set; }

        public int VendorId { get; set; }

        [Required]
        [StringLength(80)]
        public string Description { get; set; }

        public DateTime InitDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime CreateDate { get; set; }

        [Required]
        [StringLength(20)]
        public string CreatedByUser { get; set; }

        public DateTime? UpdateDate { get; set; }

        [StringLength(20)]
        public string UpdateByUser { get; set; }
    }
}
