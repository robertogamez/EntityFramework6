namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PagosProveedor")]
    public partial class PagosProveedor
    {
        public int id { get; set; }

        public int CompanyID { get; set; }

        public int brokerid { get; set; }

        public int vendorid { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime? fechapago { get; set; }

        public decimal? monto { get; set; }
    }
}
