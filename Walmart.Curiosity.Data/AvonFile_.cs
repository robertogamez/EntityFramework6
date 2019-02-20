namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LayOut.AvonFile_")]
    public partial class AvonFile_
    {
        [Key]
        public int Seq { get; set; }

        [StringLength(1000)]
        public string Detail { get; set; }

        public long? TransactionId { get; set; }
    }
}
