namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BankEntitie")]
    public partial class BankEntitie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BankEntitie()
        {
            VendorSettlements = new HashSet<VendorSettlement>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string BankEntitieId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string CountryId { get; set; }

        [Required]
        [StringLength(50)]
        public string BankEntitieName { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; }

        [Column(TypeName = "date")]
        public DateTime CreationDate { get; set; }

        [Required]
        [StringLength(20)]
        public string CreatedByUser { get; set; }

        [Column(TypeName = "date")]
        public DateTime? UpdatedDate { get; set; }

        [StringLength(20)]
        public string UpdatedByUser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendorSettlement> VendorSettlements { get; set; }
    }
}
