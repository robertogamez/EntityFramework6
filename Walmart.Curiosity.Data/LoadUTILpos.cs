namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("balance.LoadUTILpos")]
    public partial class LoadUTILpos
    {
        public int ID { get; set; }

        [StringLength(2000)]
        public string BaseChain { get; set; }

        [StringLength(10)]
        public string BaseChainType { get; set; }

        [StringLength(10)]
        public string BaseChainStoreID { get; set; }
    }
}
