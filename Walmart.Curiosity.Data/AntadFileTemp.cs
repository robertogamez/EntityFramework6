namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LayOut.AntadFileTemp")]
    public partial class AntadFileTemp
    {
        [Key]
        public int Seq { get; set; }

        [StringLength(1000)]
        public string Detail { get; set; }

        [StringLength(1000)]
        public string C1 { get; set; }

        [StringLength(1000)]
        public string C2 { get; set; }

        [StringLength(1000)]
        public string C3 { get; set; }

        [StringLength(1000)]
        public string C4 { get; set; }

        public long? TransactionId { get; set; }
    }
}
