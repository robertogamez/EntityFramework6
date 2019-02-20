namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FileReceptionConfiguration")]
    public partial class FileReceptionConfiguration
    {
        public int FileReceptionConfigurationID { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public bool? ISEncrypted { get; set; }

        [StringLength(30)]
        public string FileEncodingType { get; set; }

        [StringLength(300)]
        public string Folder { get; set; }

        [StringLength(300)]
        public string BackupFolder { get; set; }

        [StringLength(100)]
        public string PlanFileName { get; set; }

        [StringLength(50)]
        public string NamePrefix { get; set; }

        public int? Columns { get; set; }

        public bool? HasHeader { get; set; }

        [StringLength(10)]
        public string ColumnSeparator { get; set; }

        [StringLength(10)]
        public string NewLineChar { get; set; }

        [StringLength(30)]
        public string EndingType { get; set; }

        public bool? IsActive { get; set; }

        [StringLength(30)]
        public string DeliveryChannel { get; set; }

        public DateTime LastUpdatedDate { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
