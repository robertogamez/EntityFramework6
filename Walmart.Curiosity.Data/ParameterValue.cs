namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ParameterValue")]
    public partial class ParameterValue
    {
        public int ParameterValueId { get; set; }

        [Required]
        [StringLength(50)]
        public string ParameterCode { get; set; }

        public short? RecordTypeId { get; set; }

        public int? NumericValue { get; set; }

        [Required]
        [StringLength(200)]
        public string AlfNumericValue { get; set; }
    }
}
