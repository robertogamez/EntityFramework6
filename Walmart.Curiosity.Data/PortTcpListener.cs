namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PortTcpListener")]
    public partial class PortTcpListener
    {
        [Key]
        [Column(Order = 0)]
        public short PortTcpListenerId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string CountryId { get; set; }

        public int PortNumber { get; set; }

        public short ClientId { get; set; }

        [Required]
        [StringLength(300)]
        public string UrlWCFService { get; set; }

        public short RecordStatusId { get; set; }

        public DateTime CreationDate { get; set; }

        [Required]
        [StringLength(20)]
        public string CreatedByUser { get; set; }

        public DateTime UpdatedDate { get; set; }

        [Required]
        [StringLength(10)]
        public string UpdatedByUser { get; set; }

        public virtual Client Client { get; set; }

        public virtual RecordStatu RecordStatu { get; set; }
    }
}
