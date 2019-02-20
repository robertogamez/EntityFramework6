namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Action
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ActionID { get; set; }

        [Column("Action")]
        [StringLength(50)]
        public string Action1 { get; set; }

        public bool Incidence { get; set; }

        [StringLength(150)]
        public string Comments { get; set; }
    }
}
