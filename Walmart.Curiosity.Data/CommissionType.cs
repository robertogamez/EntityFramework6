namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vc.CommissionType")]
    public partial class CommissionType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CommissionType()
        {
            SubVendorCommissions = new HashSet<SubVendorCommission>();
            VendorCommissions = new HashSet<VendorCommission>();
        }

        [Key]
        [Column(Order = 0)]
        public int CommissionTypeId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string CountryId { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        public bool HasRange { get; set; }

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

        public virtual Country Country { get; set; }

        public virtual RecordStatu RecordStatu { get; set; }

        public virtual RecordType RecordType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubVendorCommission> SubVendorCommissions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendorCommission> VendorCommissions { get; set; }
    }
}
