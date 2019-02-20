namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tbcatval")]
    public partial class Tbcatval
    {
        [Key]
        [Column(Order = 0)]
        public int TbcatvalId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string CountryId { get; set; }

        [Required]
        [StringLength(11)]
        public string Cval_Codparam_0 { get; set; }

        public short Cval_Cvecod_1 { get; set; }

        [Required]
        [StringLength(15)]
        public string Cval_Vechar_0 { get; set; }

        public decimal Cval_Valnum1_5 { get; set; }

        public decimal Cval_Valnum2_5 { get; set; }

        public decimal Cval_Valnum3_5 { get; set; }

        [Required]
        [StringLength(50)]
        public string Cval_Valalf1_0 { get; set; }

        [Required]
        [StringLength(50)]
        public string Cval_Valalf2_0 { get; set; }

        [Required]
        [StringLength(50)]
        public string Cval_Valalf3_0 { get; set; }

        public short? RecordTypeId { get; set; }

        public short? RecordStatusId { get; set; }

        public virtual RecordStatu RecordStatu { get; set; }

        public virtual RecordType RecordType { get; set; }
    }
}
