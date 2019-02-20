namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CaptureLinePrefix")]
    public partial class CaptureLinePrefix
    {
        [Key]
        [Column(Order = 0, TypeName = "date")]
        public DateTime StartDate { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime EndDate { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VendorID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Prefix { get; set; }

        [Required]
        [StringLength(150)]
        public string Concept { get; set; }

        [Required]
        [StringLength(150)]
        public string Code { get; set; }

        public decimal Commission { get; set; }

        public decimal IVA { get; set; }
    }
}
