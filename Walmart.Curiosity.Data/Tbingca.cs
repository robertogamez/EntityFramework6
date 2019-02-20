namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("income.Tbingcas")]
    public partial class Tbingca
    {
        [Required]
        [StringLength(3)]
        public string CountryId { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short icas_tiporesum_1 { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short icas_cvecia_1 { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short icas_cvediv_1 { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short icas_cvedet_1 { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "date")]
        public DateTime icas_fresumen_7 { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short icas_numreng_1 { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short icas_numcasill_1 { get; set; }

        public decimal icas_importe_8 { get; set; }

        [Required]
        [StringLength(8)]
        public string icas_userid_0 { get; set; }

        public DateTime icas_fultmod_4 { get; set; }

        public DateTime CreateDate { get; set; }

        [Required]
        [StringLength(20)]
        public string CreatedByUser { get; set; }

        public DateTime UpdatedDate { get; set; }

        [Required]
        [StringLength(20)]
        public string UpdatedByUser { get; set; }
    }
}
