namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class coso1
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(150)]
        public string Banco { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(150)]
        public string Tarjeta { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Plazo { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Prefijo { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal Sobretasa { get; set; }
    }
}
