namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Module
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ModuleID { get; set; }

        [Column("Module")]
        [StringLength(50)]
        public string Module1 { get; set; }
    }
}
