namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("balance.EalUtilFile")]
    public partial class EalUtilFile
    {
        [Key]
        [Column(Order = 0, TypeName = "date")]
        public DateTime TrDate { get; set; }

        [Key]
        [Column(Order = 1)]
        public long EalUtilFileId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoreId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int POSId { get; set; }

        public int OperatorNumber { get; set; }

        public int RecordNumber { get; set; }

        public TimeSpan TrTime { get; set; }

        public short VendorPosId { get; set; }

        [Required]
        [StringLength(35)]
        public string CustomerAccountId { get; set; }

        public short EntryTypeId { get; set; }

        public decimal Amount { get; set; }

        public short TenderType { get; set; }

        public short SignIndicator { get; set; }

        [Required]
        [StringLength(20)]
        public string AuthorizationNumber { get; set; }

        public short OnlineIndicator { get; set; }

        [Required]
        [StringLength(6)]
        public string BINNumber { get; set; }

        [Required]
        [StringLength(1)]
        public string Type { get; set; }

        [Required]
        [StringLength(1)]
        public string PCIIndicator { get; set; }

        public short EncryptedDatalength { get; set; }

        public DateTime DateTimeStamp { get; set; }
    }
}
