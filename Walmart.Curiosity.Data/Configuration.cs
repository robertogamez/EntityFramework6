namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Configuration")]
    public partial class Configuration
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ConfigurationID { get; set; }

        [StringLength(50)]
        public string KeyConfiguration { get; set; }

        [StringLength(50)]
        public string Value { get; set; }

        [StringLength(300)]
        public string Description { get; set; }
    }
}
