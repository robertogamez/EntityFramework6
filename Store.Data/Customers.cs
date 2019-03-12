namespace Store.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customers
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public string Country { get; set; }
    }
}
