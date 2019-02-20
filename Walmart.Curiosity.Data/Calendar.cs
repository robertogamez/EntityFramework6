namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Calendar")]
    public partial class Calendar
    {
        [Key]
        [Column(TypeName = "date")]
        public DateTime CalendarDate { get; set; }

        public int CalendarYear { get; set; }

        public int CalendarMonth { get; set; }

        public int CalendarDay { get; set; }

        [Required]
        [StringLength(10)]
        public string DayOfWeekName { get; set; }

        [Required]
        [StringLength(12)]
        public string DayOfWeekNameEs { get; set; }

        [Required]
        [StringLength(10)]
        public string DscShortMonthEs { get; set; }

        [Required]
        [StringLength(10)]
        public string DscShortMonth { get; set; }

        [Required]
        [StringLength(20)]
        public string DscMonth { get; set; }

        [Required]
        [StringLength(20)]
        public string DscMonthEs { get; set; }

        [Column(TypeName = "date")]
        public DateTime FirstDateOfWeek { get; set; }

        [Column(TypeName = "date")]
        public DateTime LastDateOfWeek { get; set; }

        [Column(TypeName = "date")]
        public DateTime FirstDateOfMonth { get; set; }

        [Column(TypeName = "date")]
        public DateTime LastDateOfMonth { get; set; }

        [Column(TypeName = "date")]
        public DateTime FirstDateOfQuarter { get; set; }

        [Column(TypeName = "date")]
        public DateTime LastDateOfQuarter { get; set; }

        [StringLength(2)]
        public string QuarterName { get; set; }

        [Column(TypeName = "date")]
        public DateTime FirstDateOfYear { get; set; }

        [Column(TypeName = "date")]
        public DateTime LastDateOfYear { get; set; }

        public bool BusinessDay { get; set; }

        public bool NonBusinessDay { get; set; }

        public int FiscalYear { get; set; }

        [Required]
        [StringLength(4)]
        public string FiscalYearName { get; set; }

        public byte FiscalYearOrder { get; set; }

        public bool Weekend { get; set; }

        public bool Holiday { get; set; }

        public bool Weekday { get; set; }

        [StringLength(50)]
        public string CalendarDateDescription { get; set; }
    }
}
