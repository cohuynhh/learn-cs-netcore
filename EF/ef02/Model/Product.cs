using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Model
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int ProductId {set; get;}

        [Required]
        [StringLength(50)]
        public string Name {set; get;}

        [Column(TypeName="Money")]
        public decimal Price {set; get;}


        // public int? CategoryId {set; get;}

        // [Required]
        // [ForeignKey("CategoryId")]
        public Category Category {set; get;}
    }
}