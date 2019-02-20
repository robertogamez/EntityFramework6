namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Format")]
    public partial class Format
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Format()
        {
            FormatConversionByVendors = new HashSet<FormatConversionByVendor>();
            Stores = new HashSet<Store>();
            VendorFormats = new HashSet<VendorFormat>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FormatId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string CountryId { get; set; }

        [StringLength(10)]
        public string SubBusinessTypeId { get; set; }

        [StringLength(10)]
        public string FormatCode { get; set; }

        [StringLength(10)]
        public string FormatShortDesc { get; set; }

        [StringLength(40)]
        public string FormatDesc { get; set; }

        public int? CompanyId { get; set; }

        public virtual Company Company { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FormatConversionByVendor> FormatConversionByVendors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Store> Stores { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendorFormat> VendorFormats { get; set; }
    }
}
