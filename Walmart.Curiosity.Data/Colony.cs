namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Colony")]
    public partial class Colony
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Colony()
        {
            Brokers = new HashSet<Broker>();
        }

        [Key]
        [Column(Order = 0)]
        public int ColonyId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string CountryId { get; set; }

        [Required]
        [StringLength(10)]
        public string ZipCode { get; set; }

        [Required]
        [StringLength(100)]
        public string ColonyName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Broker> Brokers { get; set; }
    }
}
