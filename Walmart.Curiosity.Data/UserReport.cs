namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("rpt.UserReports")]
    public partial class UserReport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserReport()
        {
            ReportsColumns = new HashSet<ReportsColumn>();
        }

        [Key]
        public int ReportId { get; set; }

        [Required]
        [StringLength(20)]
        public string UserId { get; set; }

        [Required]
        [StringLength(100)]
        public string ReportName { get; set; }

        public int StatusId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReportsColumn> ReportsColumns { get; set; }
    }
}
