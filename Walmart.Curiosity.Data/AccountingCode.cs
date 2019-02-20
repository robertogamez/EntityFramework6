namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("accountant.AccountingCode")]
    public partial class AccountingCode
    {
        [Key]
        [Column(Order = 0)]
        public int AccountingCodeId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string CountryId { get; set; }

        public int? CompanyId { get; set; }

        public int? StoreId { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; }

        public virtual Country Country { get; set; }
    }
}
