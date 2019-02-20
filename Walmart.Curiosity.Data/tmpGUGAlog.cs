namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("balance.tmpGUGAlog")]
    public partial class tmpGUGAlog
    {
        public int id { get; set; }

        public int? Cantidad { get; set; }

        [StringLength(150)]
        public string Concepto { get; set; }

        [StringLength(10)]
        public string fechagen { get; set; }
    }
}
