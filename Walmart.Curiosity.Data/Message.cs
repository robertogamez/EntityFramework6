namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Message
    {
        public int MessageID { get; set; }

        public int? ModuleID { get; set; }

        public int? ActionID { get; set; }

        [StringLength(3000)]
        public string Description { get; set; }
    }
}
