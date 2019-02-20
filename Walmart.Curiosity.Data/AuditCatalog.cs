namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("audit.AuditCatalogs")]
    public partial class AuditCatalog
    {
        [Key]
        public int AuditId { get; set; }

        [StringLength(1)]
        public string TYPE { get; set; }

        [StringLength(128)]
        public string TableName { get; set; }

        [StringLength(1000)]
        public string PK { get; set; }

        [StringLength(128)]
        public string FieldName { get; set; }

        [StringLength(1000)]
        public string OldValue { get; set; }

        [StringLength(1000)]
        public string NewValue { get; set; }

        public DateTime? UpdateDate { get; set; }

        [StringLength(128)]
        public string UserName { get; set; }
    }
}
