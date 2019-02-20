namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vc.VendorSettlement")]
    public partial class VendorSettlement
    {
        [Key]
        [Column(Order = 0)]
        public int VendorSettlementId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string CountryId { get; set; }

        public int? VendorId { get; set; }

        public int? BrokerId { get; set; }

        public short? SettlementAmountDay { get; set; }

        public short? SettlementNettingDay { get; set; }

        [Required]
        [StringLength(3)]
        public string PaymentTypeProviderId { get; set; }

        [Required]
        [StringLength(3)]
        public string BankEntitieId { get; set; }

        [StringLength(60)]
        public string SettlementAccount { get; set; }

        [StringLength(60)]
        public string SettlementCLABE { get; set; }

        public short? RecordTypeId { get; set; }

        public short? RecordStatusId { get; set; }

        public DateTime CreationDate { get; set; }

        [Required]
        [StringLength(20)]
        public string CreatedByUser { get; set; }

        public DateTime UpdatedDate { get; set; }

        [Required]
        [StringLength(20)]
        public string UpdatedByUser { get; set; }

        public virtual BankEntitie BankEntitie { get; set; }

        public virtual Broker Broker { get; set; }

        public virtual RecordStatu RecordStatu { get; set; }

        public virtual RecordType RecordType { get; set; }

        public virtual Vendor Vendor { get; set; }

        public virtual PaymentTypeProvider PaymentTypeProvider { get; set; }
    }
}
