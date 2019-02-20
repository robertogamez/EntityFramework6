namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TransactionSummary_Ini
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string PosTrId_2 { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoreId_2 { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CashierNumber_2 { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(60)]
        public string ServiceReference_2 { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TerminalNumber_2 { get; set; }

        public int? DeterminanteId { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(200)]
        public string DeterminanteNombre { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(8)]
        public string IsOnline { get; set; }

        public bool? EstatusOp { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaCrea { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "date")]
        public DateTime FechaPago { get; set; }

        [StringLength(8)]
        public string HoraCrea { get; set; }

        [StringLength(60)]
        public string NoCuenta { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TransactionId { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal TsAmount { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal TotalCuriosity { get; set; }

        public int? VendorId { get; set; }

        [StringLength(10)]
        public string CajeroId { get; set; }

        [StringLength(10)]
        public string TerminalId { get; set; }

        [StringLength(1)]
        public string EntryModeId { get; set; }

        public short? EstatusId { get; set; }

        [Key]
        [Column(Order = 11)]
        public DateTime TrDateTime { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(3)]
        public string CountryId { get; set; }

        public short? TransactionTypeId { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(10)]
        public string PosTrId { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoreId { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CashierNumber { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(60)]
        public string ServiceReference { get; set; }

        [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TerminalNumber { get; set; }

        [Key]
        [Column(Order = 18, TypeName = "date")]
        public DateTime TrDate { get; set; }

        public short? RecordStatusId { get; set; }

        public int? PaymentTypeId { get; set; }
    }
}
