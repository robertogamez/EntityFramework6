namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VendorPaymentDetail")]
    public partial class VendorPaymentDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VendorPaymentDetail()
        {
            VendorPaymentSubDetails = new HashSet<VendorPaymentSubDetail>();
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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short SequenceDetail { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(3)]
        public string CountryId { get; set; }

        [Required]
        [StringLength(32)]
        public string UniqueId { get; set; }

        [StringLength(50)]
        public string Tag { get; set; }

        [StringLength(4000)]
        public string TagValue { get; set; }

        public bool IsOnline { get; set; }

        public virtual VendorPaymentHeader VendorPaymentHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendorPaymentSubDetail> VendorPaymentSubDetails { get; set; }
    }
}
