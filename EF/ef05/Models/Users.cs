using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef05.Models
{
    [Table("users")]
    public partial class Users
    {
        public Users()
        {
            Products = new HashSet<Products>();
        }

        [Key]
        public int UserId { get; set; }
        [StringLength(20)]
        public string UserName { get; set; }

        [InverseProperty("UserPost")]
        public virtual ICollection<Products> Products { get; set; }
    }
}
