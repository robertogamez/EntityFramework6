namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prefixConcept
    {
        public int PrefixConceptId { get; set; }

        [Required]
        [StringLength(80)]
        public string Description { get; set; }

        public DateTime CreationDate { get; set; }

        [Required]
        [StringLength(20)]
        public string CreatedByUser { get; set; }

        public DateTime? UpdateDate { get; set; }

        [StringLength(20)]
        public string UpadteByUser { get; set; }
    }
}
