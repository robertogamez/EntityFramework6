namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TypesOfAccounting")]
    public partial class TypesOfAccounting
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TypeAccountigID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string Type { get; set; }

        [StringLength(50)]
        public string Description { get; set; }
    }
}
