namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TblConcentradoProveedore
    {
        [Key]
        public int idconcentrado { get; set; }

        public int Brokerid { get; set; }

        public int Vendorid { get; set; }

        [Required]
        [StringLength(13)]
        public string Rfc { get; set; }

        [Required]
        [StringLength(20)]
        public string Shortname { get; set; }

        [Required]
        [StringLength(50)]
        public string Legalname { get; set; }

        [Required]
        [StringLength(3)]
        public string idPais { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoProveedor { get; set; }

        [Required]
        [StringLength(50)]
        public string ActividadProveedor { get; set; }

        [Required]
        [StringLength(8)]
        public string EstatusProveedor { get; set; }

        [Required]
        [StringLength(7)]
        public string Tpago { get; set; }

        [Required]
        [StringLength(8)]
        public string Cp { get; set; }

        [Required]
        [StringLength(50)]
        public string Calle { get; set; }

        [Required]
        [StringLength(5)]
        public string NoExt { get; set; }

        [StringLength(5)]
        public string NoInt { get; set; }

        [Required]
        [StringLength(50)]
        public string Colonia { get; set; }

        [Required]
        [StringLength(50)]
        public string Mundel { get; set; }

        public int Stated { get; set; }

        [Required]
        [StringLength(13)]
        public string Telefono { get; set; }

        public int TipoTelefono { get; set; }

        [StringLength(75)]
        public string Email { get; set; }

        [StringLength(1)]
        public string recibeEfec { get; set; }

        [StringLength(1)]
        public string recibeBancomer { get; set; }

        [StringLength(1)]
        public string recibeWalmart { get; set; }

        [StringLength(1)]
        public string recibeAmexco { get; set; }

        [StringLength(1)]
        public string recibeNomina { get; set; }

        [StringLength(1)]
        public string recibeDebito { get; set; }

        [StringLength(1)]
        public string recibeBanamex { get; set; }

        [StringLength(1)]
        public string recibeCarnet { get; set; }

        [StringLength(5)]
        public string RenglonIngresos { get; set; }

        [StringLength(5)]
        public string CasilleroIngresos { get; set; }

        [StringLength(2)]
        public string ClaveIngresos { get; set; }

        [StringLength(2)]
        public string AjustePositivo { get; set; }

        [StringLength(2)]
        public string AjusteNegativo { get; set; }

        [StringLength(2)]
        public string DigitoVerificador { get; set; }

        [StringLength(2)]
        public string AceptaPagoVencido { get; set; }

        [StringLength(5)]
        public string IniCuenta { get; set; }

        [StringLength(5)]
        public string FinCuenta { get; set; }

        public int? LongCodigoBarras { get; set; }
    }
}
