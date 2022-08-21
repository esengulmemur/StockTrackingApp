using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class Customer : Entity
    {
        [MaxLength(20)]
        public string TC { get; set; }
        [MaxLength(50)]
        public string FullName { get; set; }
        [MaxLength(20)]
        public string PhoneNumber { get; set; }
        [MaxLength(100)]
        public string Adress { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
    }
}
