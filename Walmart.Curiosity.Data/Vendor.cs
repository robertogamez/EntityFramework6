namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vendor")]
    public partial class Vendor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vendor()
        {
            Accountings = new HashSet<Accounting>();
            AccountingByTransactions = new HashSet<AccountingByTransaction>();
            InvoiceControls = new HashSet<InvoiceControl>();
            IncomingFiles = new HashSet<IncomingFile>();
            FormatConversionByVendors = new HashSet<FormatConversionByVendor>();
            MasterVendors = new HashSet<MasterVendor>();
            IncomingFile_back = new HashSet<IncomingFile_back>();
            SubVendors = new HashSet<SubVendor>();
            VendorBalanceInquiryHeaders = new HashSet<VendorBalanceInquiryHeader>();
            VendorCities = new HashSet<VendorCity>();
            VendorCommissions = new HashSet<VendorCommission>();
            VendorCompanyTmps = new HashSet<VendorCompanyTmp>();
            VendorFormats = new HashSet<VendorFormat>();
            VendorIncomeConfigs = new HashSet<VendorIncomeConfig>();
            VendorPaymentHeaders = new HashSet<VendorPaymentHeader>();
            VendorPaymentTypes = new HashSet<VendorPaymentType>();
            VendorReverseHeaders = new HashSet<VendorReverseHeader>();
            VendorSettlements = new HashSet<VendorSettlement>();
            VendorUris = new HashSet<VendorUri>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VendorId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string CountryId { get; set; }

        [StringLength(2000)]
        public string XmlConfig { get; set; }

        public bool UseBroker { get; set; }

        public int? BrokerId { get; set; }

        public int VendorTypeId { get; set; }

        [Required]
        [StringLength(1000)]
        public string LegalName { get; set; }

        [Required]
        [StringLength(100)]
        public string VendorNameShort { get; set; }

        [Required]
        [StringLength(1000)]
        public string ActivityDescription { get; set; }

        [Required]
        [StringLength(50)]
        public string RFC { get; set; }

        public bool AuthRequired { get; set; }

        public bool AccountValidation { get; set; }

        public int ReferenceLong { get; set; }

        public short RecordTypeId { get; set; }

        public short RecordStatusId { get; set; }

        [StringLength(20)]
        public string ShippingType { get; set; }

        [StringLength(20)]
        public string Layout { get; set; }

        [StringLength(20)]
        public string ShippingStatus { get; set; }

        [StringLength(20)]
        public string FileType { get; set; }

        [StringLength(20)]
        public string TransferType { get; set; }

        public DateTime CreateDate { get; set; }

        [Required]
        [StringLength(20)]
        public string CreatedByUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(20)]
        public string UpdatedByUser { get; set; }

        [StringLength(1000)]
        public string Street { get; set; }

        [StringLength(20)]
        public string NumExt { get; set; }

        [StringLength(20)]
        public string NumInt { get; set; }

        public int? ColonyId { get; set; }

        public int? CityId { get; set; }

        public short? StateId { get; set; }

        [StringLength(3)]
        public string CountryId2 { get; set; }

        [StringLength(10)]
        public string ZipCode { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

        public int? PhoneTypeId { get; set; }

        [StringLength(1000)]
        public string ContactEmail { get; set; }

        public bool? CreateIncomeFile { get; set; }

        public bool? CreateAPFile { get; set; }

        public bool? AllowConsultOnline { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(50)]
        public string StatusNotificacion { get; set; }

        public bool NegativeAdjustment { get; set; }

        public bool PositiveAdjustment { get; set; }

        public bool? EnabledQueryAmount { get; set; }

        public int? CreateFrontCommission { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Accounting> Accountings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountingByTransaction> AccountingByTransactions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceControl> InvoiceControls { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IncomingFile> IncomingFiles { get; set; }

        public virtual Broker Broker { get; set; }

        public virtual Country Country { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FormatConversionByVendor> FormatConversionByVendors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MasterVendor> MasterVendors { get; set; }

        public virtual RecordStatu RecordStatu { get; set; }

        public virtual RecordType RecordType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IncomingFile_back> IncomingFile_back { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubVendor> SubVendors { get; set; }

        public virtual VendorType VendorType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendorBalanceInquiryHeader> VendorBalanceInquiryHeaders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendorCity> VendorCities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendorCommission> VendorCommissions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendorCompanyTmp> VendorCompanyTmps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendorFormat> VendorFormats { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendorIncomeConfig> VendorIncomeConfigs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendorPaymentHeader> VendorPaymentHeaders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendorPaymentType> VendorPaymentTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendorReverseHeader> VendorReverseHeaders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendorSettlement> VendorSettlements { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendorUri> VendorUris { get; set; }

        public virtual VendorValidation VendorValidation { get; set; }
    }
}
