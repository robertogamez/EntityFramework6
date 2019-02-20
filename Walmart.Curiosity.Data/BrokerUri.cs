namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BrokerUri")]
    public partial class BrokerUri
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BrokerId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short TransactionTypeId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(3)]
        public string CountryId { get; set; }

        [Required]
        [StringLength(500)]
        public string Uri { get; set; }

        [Required]
        [StringLength(10)]
        public string Bin { get; set; }

        public int TimeOut { get; set; }

        public short? RecordStatusId { get; set; }

        public virtual Broker Broker { get; set; }

        public virtual Country Country { get; set; }

        public virtual TransactionType TransactionType { get; set; }
    }
}
