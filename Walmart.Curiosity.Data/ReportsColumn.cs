namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("rpt.ReportsColumns")]
    public partial class ReportsColumn
    {
        public int Id { get; set; }

        public int ReportId { get; set; }

        public int ColumnId { get; set; }

        public int OrderId { get; set; }

        public virtual TransactionsReportLayout TransactionsReportLayout { get; set; }

        public virtual UserReport UserReport { get; set; }
    }
}
