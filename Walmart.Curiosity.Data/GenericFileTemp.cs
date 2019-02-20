namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LayOut.GenericFileTemp")]
    public partial class GenericFileTemp
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

        public int? TransactionId { get; set; }
    }
}
