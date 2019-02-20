namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("balance.BalanceGUGATemp")]
    public partial class BalanceGUGATemp
    {
        [Key]
        public int Sec { get; set; }

        [StringLength(120)]
        public string CuerpoRep { get; set; }

        [StringLength(25)]
        public string transactionid { get; set; }

        [StringLength(5)]
        public string Recordtypeid { get; set; }
    }
}
