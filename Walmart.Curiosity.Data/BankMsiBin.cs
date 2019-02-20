namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BankMsiBin
    {
        [Key]
        [Column(Order = 0, TypeName = "date")]
        public DateTime StartDate { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime EndDate { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VendorID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Bin { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Differed { get; set; }

        public decimal surcharge { get; set; }
    }
}
