using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class Entity
    {
        [Key]
        public virtual int Id { get; set; }
    }
}
