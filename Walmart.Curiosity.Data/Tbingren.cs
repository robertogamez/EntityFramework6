namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("income.Tbingren")]
    public partial class Tbingren
    {
        [Key]
        [Column(Order = 0, TypeName = "date")]
        public DateTime SummaryDate { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoreId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(3)]
        public string CountryId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Companyid { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short DivisionId { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short SummaryType { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short RowId { get; set; }

        public decimal Amount { get; set; }

        [StringLength(8)]
        public string UserId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime UpdatedDateIncome { get; set; }

        public DateTime CreateDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime UpdatedDate { get; set; }
    }
}
