namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExternalServices.ServicesModule")]
    public partial class ServicesModule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ServicesModule()
        {
            ServicesCuriosities = new HashSet<ServicesCuriosity>();
        }

        [Key]
        public int ServiceModuleID { get; set; }

        [Required]
        [StringLength(30)]
        public string NameModule { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServicesCuriosity> ServicesCuriosities { get; set; }
    }
}
