namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ParameterList")]
    public partial class ParameterList
    {
        public int ParameterListId { get; set; }

        [Required]
        [StringLength(50)]
        public string ParameterCode { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        public short? RecordTypeId { get; set; }
    }
}
