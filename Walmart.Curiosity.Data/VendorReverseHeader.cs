namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VendorReverseHeader")]
    public partial class VendorReverseHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VendorReverseHeader()
        {
            VendorReverseDetails = new HashSet<VendorReverseDetail>();
        }

        [Key]
        [Column(Order = 0, TypeName = "date")]
        public DateTime TrDate { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TransactionId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(3)]
        public string CountryId { get; set; }

        public long OriginalTransactionId { get; set; }

        public int VendorId { get; set; }

        [StringLength(60)]
        public string MainReference { get; set; }

        [StringLength(40)]
        public string OptionalReference { get; set; }

        [StringLength(20)]
        public string AuthorizationOfflineNumber { get; set; }

        [StringLength(20)]
        public string AuthorizationNumber { get; set; }

        public DateTime TrDateTime { get; set; }

        public int StoreId { get; set; }

        [Required]
        [StringLength(20)]
        public string TerminalId { get; set; }

        [Required]
        [StringLength(5)]
        public string PosTrId { get; set; }

        public decimal Amount { get; set; }

        [Required]
        [StringLength(20)]
        public string UserNumber { get; set; }

        public bool IsOnline { get; set; }

        public short RecordTypeId { get; set; }

        public short RecordStatusId { get; set; }

        public virtual Vendor Vendor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendorReverseDetail> VendorReverseDetails { get; set; }
    }
}
