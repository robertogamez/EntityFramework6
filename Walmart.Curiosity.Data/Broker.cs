namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Broker")]
    public partial class Broker
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Broker()
        {
            InvoiceControls = new HashSet<InvoiceControl>();
            BrokerIncomeConfigs = new HashSet<BrokerIncomeConfig>();
            BrokerPaymentTypes = new HashSet<BrokerPaymentType>();
            BrokerUris = new HashSet<BrokerUri>();
            MasterVendors = new HashSet<MasterVendor>();
            Vendors = new HashSet<Vendor>();
            VendorSettlements = new HashSet<VendorSettlement>();
        }

        [Key]
        [Column(Order = 0)]
        public int BrokerId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string CountryId { get; set; }

        [Required]
        [StringLength(50)]
        public string ShortName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreationDate { get; set; }

        [StringLength(20)]
        public string CreatedByUser { get; set; }

        [Column(TypeName = "date")]
        public DateTime? UpdatedDate { get; set; }

        [StringLength(20)]
        public string UpdatedByUser { get; set; }

        public short? RecordStatusId { get; set; }

        [StringLength(50)]
        public string Rfc { get; set; }

        public int? PosId { get; set; }

        [StringLength(500)]
        public string LegalName { get; set; }

        [StringLength(1000)]
        public string Street { get; set; }

        [StringLength(20)]
        public string NumExt { get; set; }

        [StringLength(20)]
        public string NumInt { get; set; }

        [StringLength(10)]
        public string ZipCode { get; set; }

        [StringLength(1000)]
        public string ContactEmail { get; set; }

        [StringLength(3)]
        public string CountryId2 { get; set; }

        public int? CityId { get; set; }

        public int? ColonyId { get; set; }

        public short? StateId { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

        public int? PhoneTypeId { get; set; }

        public bool? CreateIncomeFile { get; set; }

        public bool? CreateAPFile { get; set; }

        public int? CreateFrontCommission { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceControl> InvoiceControls { get; set; }

        public virtual City City { get; set; }

        public virtual Colony Colony { get; set; }

        public virtual RecordStatu RecordStatu { get; set; }

        public virtual State State { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BrokerIncomeConfig> BrokerIncomeConfigs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BrokerPaymentType> BrokerPaymentTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BrokerUri> BrokerUris { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MasterVendor> MasterVendors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vendor> Vendors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendorSettlement> VendorSettlements { get; set; }
    }
}
