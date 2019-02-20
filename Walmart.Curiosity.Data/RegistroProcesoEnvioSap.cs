namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RegistroProcesoEnvioSap")]
    public partial class RegistroProcesoEnvioSap
    {
        public int Id { get; set; }

        public int? BrokerId { get; set; }

        public int? VendorId { get; set; }

        [Required]
        [StringLength(10)]
        public string Usuario { get; set; }

        public DateTime PeriodoFechaInicio { get; set; }

        public DateTime PeriodoFechaFin { get; set; }

        [Required]
        [StringLength(15)]
        public string TipoReporte { get; set; }

        public DateTime? InicioProceso { get; set; }

        public DateTime? GenerarXml { get; set; }

        public DateTime? EnvioSap { get; set; }

        [StringLength(30)]
        public string Tipo { get; set; }

        public int? PasoProceso { get; set; }
    }
}
