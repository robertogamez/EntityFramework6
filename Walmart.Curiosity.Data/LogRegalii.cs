namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LogRegalii")]
    public partial class LogRegalii
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LogRegalii()
        {
            LogRegaliiDetails = new HashSet<LogRegaliiDetail>();
        }

        [Key]
        public long LogID { get; set; }

        public DateTime? StartDateTime { get; set; }

        public DateTime? EndDateTime { get; set; }

        [StringLength(500)]
        public string MessageStart { get; set; }

        [StringLength(500)]
        public string MessageFinish { get; set; }

        public long? RecordCount { get; set; }

        public long? Processed { get; set; }

        public long? Unprocessed { get; set; }

        public string Comments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LogRegaliiDetail> LogRegaliiDetails { get; set; }
    }
}
