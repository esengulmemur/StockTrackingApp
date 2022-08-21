using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class Brand : Entity
    {
        [MaxLength(50)]
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
