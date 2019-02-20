namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LogRegaliiDetail")]
    public partial class LogRegaliiDetail
    {
        [Key]
        public long LogDetailID { get; set; }

        public long? LogID { get; set; }

        public long? TransactionID { get; set; }

        public bool? IsSuccess { get; set; }

        [StringLength(1000)]
        public string Message { get; set; }

        public long? TransactionIDRegalii { get; set; }

        public DateTime? CreatedDate { get; set; }

        public virtual LogRegalii LogRegalii { get; set; }
    }
}
