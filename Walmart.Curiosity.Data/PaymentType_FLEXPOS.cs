namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PaymentType_FLEXPOS
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string TenderTypePOS { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string TenderTypeFLEXPOS { get; set; }
    }
}
