using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Core.Entities
{
    public class Sales : Entity
    {
        [MaxLength(20)]
        public string TC { get; set; }
        [MaxLength(50)]
        public string FullName { get; set; }
        [MaxLength(20)]
        public string PhoneNumber { get; set; }
        [MaxLength(100)]
        public string BarkodeNo { get; set; }
        [MaxLength(50)]
        public string ProductName { get; set; }
        public int Amount { get; set; }
        [DataType("decimal(18,2)")]
        public decimal SalePrice { get; set; }
        [DataType("decimal(18,2)")]
        public decimal TotalPrice { get; set; }
        public DateTime Date { get; set; }
       
    }
}
