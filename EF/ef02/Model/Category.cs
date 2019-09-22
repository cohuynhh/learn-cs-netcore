using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Model
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int CategoryId {set; get;}

        [StringLength(100)]
        public string Name {set; get;}

        [Column(TypeName="NTEXT")]
        public string Description {set; get;}

        // public List<Product> Products { get; } = new List<Product>();
    }
}