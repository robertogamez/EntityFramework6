namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LayOut.ApplicationSettingVendor")]
    public partial class ApplicationSettingVendor
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ApplicationSettingVendorID { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VendorPosID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string VendorPosType { get; set; }

        [Required]
        [StringLength(50)]
        public string Tag { get; set; }

        public bool CreateIncomeFileDaily { get; set; }

        public bool CreateAPFileDaily { get; set; }

        public bool CreateGLFileDaily { get; set; }

        public bool AdjustmentsFileNextDay { get; set; }

        public bool CreateFileNextDay { get; set; }

        [Required]
        [StringLength(30)]
        public string IdentifierFileNextDay { get; set; }

        public int BackDaysProcess { get; set; }

        [Required]
        [StringLength(50)]
        public string NameFileNextDay { get; set; }

        public int NameDateFileNextDay { get; set; }

        [Required]
        [StringLength(200)]
        public string PathFileNextDay { get; set; }

        [Required]
        [StringLength(200)]
        public string PathLogNextDay { get; set; }

        [Required]
        [StringLength(200)]
        public string PathMoveNextDay { get; set; }

        [Required]
        [StringLength(200)]
        public string PathBackNextDay { get; set; }

        public bool AdjustmentsApplication { get; set; }

        public int AmountRecordTypeNextDay { get; set; }
    }
}
