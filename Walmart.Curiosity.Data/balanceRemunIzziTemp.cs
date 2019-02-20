namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("balance.balanceRemunIzziTemp")]
    public partial class balanceRemunIzziTemp
    {
        [Key]
        public int Seq { get; set; }

        [StringLength(1000)]
        public string Detail { get; set; }

        public long? C_bInt1_TrId { get; set; }

        public long? C_bInt2_rStatus { get; set; }

        public long? C_bInt2_rTypeComm { get; set; }

        public long? C_bInt3_VendorId { get; set; }

        public long? C_bInt3_SubVendorCommId { get; set; }

        public long? C_bInt4_CommisTypeId { get; set; }

        public long? C_bInt5_PaymType { get; set; }

        public decimal? C_Decim1_Amount { get; set; }

        public decimal? C_Decim2_BaseValueCom { get; set; }

        public decimal? C_Decim3_Iva { get; set; }

        public decimal? C_Decim4_CONTRAPRES { get; set; }

        public DateTime? C_dTime1_TrDateTime { get; set; }

        [StringLength(100)]
        public string C_vc1_ReqPaymntType { get; set; }

        [StringLength(100)]
        public string C_vc2_ProPaymntType { get; set; }

        [StringLength(3)]
        public string C_vc3_CountryId { get; set; }
    }
}
