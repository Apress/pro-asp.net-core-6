namespace WebApp.Models {
    public class Supplier {

        public long SupplierId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;

        public IEnumerable<Product>? Products { get; set; }
    }
}
