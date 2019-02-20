namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("accountant.CatalogueValueTmp")]
    public partial class CatalogueValueTmp
    {
        [Key]
        [Column("cval_codparam_0 ")]
        [StringLength(11)]
        public string cval_codparam_0_ { get; set; }

        [Column("cval_cvecod_1 ")]
        public int? cval_cvecod_1_ { get; set; }

        [StringLength(15)]
        public string cval_cvechar_0 { get; set; }

        public decimal? cval_valnum1_5 { get; set; }

        public decimal? cval_valnum2_5 { get; set; }

        public decimal? cval_valnum3_5 { get; set; }

        [StringLength(50)]
        public string cval_valalf1_0 { get; set; }

        [StringLength(50)]
        public string cval_valalf2_0 { get; set; }

        [StringLength(60)]
        public string cval_valalf3_0 { get; set; }
    }
}
