namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExternalServices.ServicesCuriosity")]
    public partial class ServicesCuriosity
    {
        [Key]
        public int ServiceCuriosityID { get; set; }

        [Required]
        [StringLength(200)]
        public string EndPointService { get; set; }

        [StringLength(200)]
        public string ActionService { get; set; }

        public int EnvironmentID { get; set; }

        public int ServiceModuleID { get; set; }

        public virtual Environment Environment { get; set; }

        public virtual ServicesModule ServicesModule { get; set; }
    }
}
