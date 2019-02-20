namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("balance.HistoryLoadUtil")]
    public partial class HistoryLoadUtil
    {
        [Key]
        [Column(Order = 0, TypeName = "date")]
        public DateTime DateStamp { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoreId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(3)]
        public string CountryId { get; set; }

        [Key]
        [Column("HistoryLoadUtil", Order = 3)]
        public long HistoryLoadUtil1 { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateFile { get; set; }

        [Required]
        [StringLength(1000)]
        public string NameUtilFile { get; set; }

        public short? RecordTypeId { get; set; }

        public short? RecordStatusId { get; set; }

        public DateTime DateTimeStamp { get; set; }

        public virtual RecordStatu RecordStatu { get; set; }

        public virtual RecordType RecordType { get; set; }
    }
}
