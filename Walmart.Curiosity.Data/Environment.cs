namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExternalServices.Environments")]
    public partial class Environment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Environment()
        {
            ServicesCuriosities = new HashSet<ServicesCuriosity>();
        }

        public int EnvironmentID { get; set; }

        [Required]
        [StringLength(20)]
        public string NameEnvironment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServicesCuriosity> ServicesCuriosities { get; set; }
    }
}
