namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Holiday")]
    public partial class Holiday
    {
        [Key]
        [Column(Order = 0)]
        public int HolidayId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string CountryId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? HolidayDate { get; set; }

        public int? Year { get; set; }

        public int? Mont { get; set; }

        public int? Day { get; set; }

        [StringLength(100)]
        public string HolidayDescription { get; set; }

        [Column(TypeName = "date")]
        public DateTime CreationDate { get; set; }

        [Required]
        [StringLength(20)]
        public string CreatedByUser { get; set; }

        [Column(TypeName = "date")]
        public DateTime? UpdatedDate { get; set; }

        [StringLength(20)]
        public string UpdatedByUser { get; set; }
    }
}
