namespace Walmart.Curiosity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("audit.DDLEvents")]
    public partial class DDLEvent
    {
        [Key]
        public DateTime EventDate { get; set; }

        [StringLength(64)]
        public string EventType { get; set; }

        public string EventDDL { get; set; }

        [Column(TypeName = "xml")]
        public string EventXML { get; set; }

        [StringLength(255)]
        public string DatabaseName { get; set; }

        [StringLength(255)]
        public string SchemaName { get; set; }

        [StringLength(255)]
        public string ObjectName { get; set; }

        [StringLength(64)]
        public string HostName { get; set; }

        [StringLength(32)]
        public string IPAddress { get; set; }

        [StringLength(255)]
        public string ProgramName { get; set; }

        [StringLength(255)]
        public string LoginName { get; set; }
    }
}
