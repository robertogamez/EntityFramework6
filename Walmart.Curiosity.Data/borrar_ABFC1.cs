namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class borrar_ABFC1
    {
        public int? BrokerID { get; set; }

        [StringLength(50)]
        public string BrokerName { get; set; }

        public int? VendorID { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string VendorName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(11)]
        public string SettlementType { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime TrDate { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PagoRegCredito { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PagoRegEfectivo { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PagoRegDebito { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PagoRegNC { get; set; }

        public int? PagoTotal { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal PagoMontoCredito { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal PagoMontoEfectivo { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal PagoMontoDebito { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal PagoMontoNC { get; set; }

        public decimal? PagoMontoTotal { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AjustesRegCredito { get; set; }

        [Key]
        [Column(Order = 12)]
        public decimal AjustesMontoCredito { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AjustesRegEfectivo { get; set; }

        [Key]
        [Column(Order = 14)]
        public decimal AjustesMontoEfectivo { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AjustesRegDebito { get; set; }

        [Key]
        [Column(Order = 16)]
        public decimal AjustesMontoDebito { get; set; }

        [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AjustesRegNC { get; set; }

        [Key]
        [Column(Order = 18)]
        public decimal AjustesMontoNC { get; set; }

        [Key]
        [Column(Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AjusteNegRegCredito { get; set; }

        [Key]
        [Column(Order = 20)]
        public decimal AjusteNegMontoCredito { get; set; }

        [Key]
        [Column(Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AjusteNegRegEfectivo { get; set; }

        [Key]
        [Column(Order = 22)]
        public decimal AjusteNegMontoEfectivo { get; set; }

        [Key]
        [Column(Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AjusteNegRegDebito { get; set; }

        [Key]
        [Column(Order = 24)]
        public decimal AjusteNegMontoDebito { get; set; }

        [Key]
        [Column(Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AjusteNegRegNC { get; set; }

        [Key]
        [Column(Order = 26)]
        public decimal AjusteNegMontoNC { get; set; }

        public int? TotalTransacciones { get; set; }

        public decimal? TotalMontos { get; set; }

        [Key]
        [Column(Order = 27)]
        public decimal ComisionPagoCredito { get; set; }

        [Key]
        [Column(Order = 28)]
        public decimal IvaCredito { get; set; }

        [Key]
        [Column(Order = 29)]
        public decimal ComisionPagoEfectivo { get; set; }

        [Key]
        [Column(Order = 30)]
        public decimal IvaEfectivo { get; set; }

        [Key]
        [Column(Order = 31)]
        public decimal ComisionPagoDebito { get; set; }

        [Key]
        [Column(Order = 32)]
        public decimal IvaDebito { get; set; }

        [Key]
        [Column(Order = 33)]
        public decimal ComisionPagoNC { get; set; }

        [Key]
        [Column(Order = 34)]
        public decimal IvaNC { get; set; }

        [Key]
        [Column(Order = 35)]
        public decimal ComisionAjusteCredito { get; set; }

        [Key]
        [Column(Order = 36)]
        public decimal AjusteIvaCredito { get; set; }

        [Key]
        [Column(Order = 37)]
        public decimal ComisionAjusteEfectivo { get; set; }

        [Key]
        [Column(Order = 38)]
        public decimal AjusteIvaEfectivo { get; set; }

        [Key]
        [Column(Order = 39)]
        public decimal ComisionAjusteDebito { get; set; }

        [Key]
        [Column(Order = 40)]
        public decimal AjusteIvaDebito { get; set; }

        [Key]
        [Column(Order = 41)]
        public decimal ComisionAjusteNC { get; set; }

        [Key]
        [Column(Order = 42)]
        public decimal AjusteIvaNC { get; set; }

        [Key]
        [Column(Order = 43)]
        public decimal ComisionAjusteNegCredito { get; set; }

        [Key]
        [Column(Order = 44)]
        public decimal IvaNegCredito { get; set; }

        [Key]
        [Column(Order = 45)]
        public decimal ComisionAjusteNegEfectivo { get; set; }

        [Key]
        [Column(Order = 46)]
        public decimal IvaNegEfectivo { get; set; }

        [Key]
        [Column(Order = 47)]
        public decimal ComisionAjusteNegDebito { get; set; }

        [Key]
        [Column(Order = 48)]
        public decimal IvaNegDebito { get; set; }

        [Key]
        [Column(Order = 49)]
        public decimal ComisionAjusteNegNC { get; set; }

        [Key]
        [Column(Order = 50)]
        public decimal IvaNegNC { get; set; }

        public decimal? TotalMontoComision { get; set; }

        public decimal? TotalIvaComision { get; set; }

        public decimal? TotalMontoAjustes { get; set; }

        public decimal? TotalIvaAjustes { get; set; }

        public decimal? TotalMontoAjustesNeg { get; set; }

        public decimal? TotalIvaNeg { get; set; }

        public decimal? GranTotalComision { get; set; }

        public decimal? GranTotalComisionIva { get; set; }

        public decimal? TotalCuentaPorPagar { get; set; }

        public decimal? TotalCuentaPorCobrar { get; set; }

        [Key]
        [Column(Order = 51, TypeName = "numeric")]
        public decimal PEP { get; set; }

        [Key]
        [Column(Order = 52)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SAP { get; set; }

        public decimal? DiferenciaPago { get; set; }
    }
}
