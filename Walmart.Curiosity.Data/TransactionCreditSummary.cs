namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransactionCreditSummary")]
    public partial class TransactionCreditSummary
    {
        [Key]
        [Column(Order = 0, TypeName = "date")]
        public DateTime TrDate { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TransactionId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(3)]
        public string CountryId { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string BankAutoritationNumber { get; set; }

        public DateTime? trDateTimeServer { get; set; }

        public decimal? Ammount { get; set; }

        [StringLength(50)]
        public string TcBin { get; set; }

        [StringLength(50)]
        public string CardType { get; set; }

        [StringLength(100)]
        public string BankName { get; set; }

        public int? DifferedMonths { get; set; }

        public decimal? BankID { get; set; }

        public DateTime? TefMatchDate { get; set; }

        [StringLength(50)]
        public string LastFourBin { get; set; }
    }
}
