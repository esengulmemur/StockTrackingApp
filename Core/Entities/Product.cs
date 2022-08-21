using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    public class Product : Entity
    {
        [MaxLength(50)]
        public string Barcode { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public int Amount { get; set; }
        [DataType("decimal(18,2)")]
        public decimal PurchasePrice { get; set; }
        [DataType("decimal(18,2)")]
        public decimal SalePrice { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        [ForeignKey("Brand")]
        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }
    }
}
