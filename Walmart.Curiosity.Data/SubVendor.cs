namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vc.SubVendor")]
    public partial class SubVendor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SubVendor()
        {
            SubVendorBins = new HashSet<SubVendorBin>();
            SubVendorCommissions = new HashSet<SubVendorCommission>();
            SubVendorPaymentTypes = new HashSet<SubVendorPaymentType>();
            SubVendorValidations = new HashSet<SubVendorValidation>();
        }

        [Key]
        [Column(Order = 0)]
        public int SubVendorId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string CountryId { get; set; }

        public int VendorId { get; set; }

        [Required]
        [StringLength(1000)]
        public string LegalName { get; set; }

        [Required]
        [StringLength(100)]
        public string SubVendorNameShort { get; set; }

        [Required]
        [StringLength(1000)]
        public string ActivityDescription { get; set; }

        [StringLength(50)]
        public string RFC { get; set; }

        public short? RecordTypeId { get; set; }

        public short? RecordStatusId { get; set; }

        public DateTime CreationDate { get; set; }

        [Required]
        [StringLength(20)]
        public string CreatedByUser { get; set; }

        public DateTime UpdatedDate { get; set; }

        [Required]
        [StringLength(20)]
        public string UpdatedByUser { get; set; }

        public virtual RecordStatu RecordStatu { get; set; }

        public virtual RecordType RecordType { get; set; }

        public virtual Vendor Vendor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubVendorBin> SubVendorBins { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubVendorCommission> SubVendorCommissions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubVendorPaymentType> SubVendorPaymentTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubVendorValidation> SubVendorValidations { get; set; }
    }
}
