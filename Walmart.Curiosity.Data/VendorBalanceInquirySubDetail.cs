namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VendorBalanceInquirySubDetail")]
    public partial class VendorBalanceInquirySubDetail
    {
        [Key]
        [Column(Order = 0, TypeName = "date")]
        public DateTime TrDate { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TransactionId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short SequenceDetail { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short SequenceSubDetail { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(3)]
        public string CountryId { get; set; }

        public int? TagSectionKey { get; set; }

        [StringLength(10)]
        public string TagType { get; set; }

        [StringLength(50)]
        public string Tag { get; set; }

        [StringLength(50)]
        public string TagValue { get; set; }

        public bool IsOline { get; set; }

        public virtual VendorBalanceInquiryDetail VendorBalanceInquiryDetail { get; set; }
    }
}
