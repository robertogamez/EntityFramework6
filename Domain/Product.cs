namespace Domain
{
    public partial class Product
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public decimal Price { get; set; }

        public int Color { get; set; }

        public bool InStock { get; set; }
    }
}
