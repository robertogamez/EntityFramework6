namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TenderType")]
    public partial class TenderType
    {
        [Key]
        [Column(Order = 0)]
        public int TenderTypeId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string CountryId { get; set; }

        [Required]
        [StringLength(3)]
        public string TenderTypePos { get; set; }

        public int CompanyId { get; set; }

        [Required]
        [StringLength(5)]
        public string TenderTypeCode { get; set; }

        public int? PaymentTypeId { get; set; }

        public virtual Country Country { get; set; }

        public virtual PaymentType PaymentType { get; set; }
    }
}
