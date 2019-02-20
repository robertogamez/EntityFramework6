namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblConfigCargaMasiva")]
    public partial class TblConfigCargaMasiva
    {
        public int Id { get; set; }

        [StringLength(25)]
        public string CampoArchivo { get; set; }

        [StringLength(30)]
        public string NombreArchivo { get; set; }

        [StringLength(5)]
        public string TipoArchivo { get; set; }

        [StringLength(25)]
        public string Columna { get; set; }

        [StringLength(15)]
        public string Tipodedato { get; set; }

        [StringLength(60)]
        public string NombreTabla { get; set; }

        [StringLength(60)]
        public string Modulo { get; set; }

        public int? Orden { get; set; }
    }
}
