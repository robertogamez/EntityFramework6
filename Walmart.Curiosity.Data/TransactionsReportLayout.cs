namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("rpt.TransactionsReportLayout")]
    public partial class TransactionsReportLayout
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TransactionsReportLayout()
        {
            ReportsColumns = new HashSet<ReportsColumn>();
        }

        [Key]
        public int ColumnId { get; set; }

        [Required]
        [StringLength(100)]
        public string ColumnLayoutObject { get; set; }

        [Required]
        [StringLength(100)]
        public string ColumnDescription { get; set; }

        public short ColumnStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReportsColumn> ReportsColumns { get; set; }
    }
}
