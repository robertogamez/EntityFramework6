namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("balance.GL02LayOut")]
    public partial class GL02LayOut
    {
        [Key]
        public int GL02_Id { get; set; }

        public int? Register_Id { get; set; }

        public long? CuriosityInvoiceNumber { get; set; }

        [StringLength(10)]
        public string StoreId { get; set; }

        public int? AccountingCodeId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TrDate { get; set; }

        public long? VendorPosId { get; set; }

        public string Body { get; set; }

        public decimal? Amount { get; set; }

        [StringLength(3)]
        public string CompanyId { get; set; }

        public long? InvoiceControlId { get; set; }

        [StringLength(1)]
        public string Sing_A { get; set; }

        [StringLength(5)]
        public string InterfaceTypeId { get; set; }
    }
}
