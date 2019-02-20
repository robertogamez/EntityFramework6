namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("balance.BalanceANTADTemp")]
    public partial class BalanceANTADTemp
    {
        [Key]
        public int Sec { get; set; }

        [StringLength(95)]
        public string CuerpoRep { get; set; }

        [StringLength(25)]
        public string transactionid { get; set; }

        [StringLength(5)]
        public string Recordtypeid { get; set; }
    }
}
