using System.ComponentModel.DataAnnotations;

namespace StockTrackingApp.BL
{
    public class Entity
    {
        [Key]
        public virtual int Id { get; set; }
    }
}
