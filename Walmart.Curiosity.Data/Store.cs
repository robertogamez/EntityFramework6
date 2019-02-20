namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Store")]
    public partial class Store
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoreId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string CountryId { get; set; }

        [Required]
        [StringLength(200)]
        public string StoreName { get; set; }

        public short RecordStatusId { get; set; }

        public short? StateId { get; set; }

        public int? CompanyId { get; set; }

        public short? DivisionId { get; set; }

        public int? FormatId { get; set; }

        public short? BusinessId { get; set; }

        public int? ZipCode { get; set; }

        [Column(TypeName = "date")]
        public DateTime CreationDate { get; set; }

        [Required]
        [StringLength(20)]
        public string CreatedByUser { get; set; }

        [Column(TypeName = "date")]
        public DateTime? UpdatedDate { get; set; }

        [StringLength(20)]
        public string UpdatedByUser { get; set; }

        public virtual Company Company { get; set; }

        public virtual Format Format { get; set; }

        public virtual RecordStatu RecordStatu { get; set; }
    }
}
