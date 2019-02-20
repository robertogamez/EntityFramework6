namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LogRegaliiDate
    {
        [Key]
        public long LogDatesID { get; set; }

        public long LogID { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateInFile { get; set; }

        public long RegCount { get; set; }
    }
}
