namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vc.SubVendorCommission")]
    public partial class SubVendorCommission
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SubVendorCommission()
        {
            Commission1 = new HashSet<Commission1>();
        }

        [Key]
        [Column(Order = 0)]
        public int SubVendorCommissionId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string CountryId { get; set; }

        public int SubVendorId { get; set; }

        public int CommissionTypeId { get; set; }

        public decimal? InitRange { get; set; }

        public decimal? EndRange { get; set; }

        public decimal Value { get; set; }

        public decimal? iva { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public bool CustomerCommission { get; set; }

        [StringLength(100)]
        public string EFT { get; set; }

        [StringLength(50)]
        public string ChargeDeadline { get; set; }

        [StringLength(50)]
        public string PaymentDeadline { get; set; }

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

        [Column(TypeName = "date")]
        public DateTime? StartDateEffect { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EndDateEffect { get; set; }

        public int PaymentTypeId { get; set; }

        public int? GroupId { get; set; }

        public virtual RecordStatu RecordStatu { get; set; }

        public virtual RecordType RecordType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Commission1> Commission1 { get; set; }

        public virtual CommissionType CommissionType { get; set; }

        public virtual PaymentType PaymentType { get; set; }

        public virtual SubVendor SubVendor { get; set; }
    }
}
