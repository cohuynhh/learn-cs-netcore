using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Product
{
    [Table("Products")]
    public class Product
    {
        public int ProductId {set; get;}

        [Required]
        [StringLength(50)]
        public string Name {set; get;}

        [StringLength(50)]
        public string Provider {set; get;}
    }
}