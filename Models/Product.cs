using System.ComponentModel.DataAnnotations.Schema;

namespace aspnetcoregraphql
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
    public class V1
    {
        public int Id { get; set; }   
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        [ForeignKey("CategoryId")]
        public V2 Category { get; set; }

    }
}