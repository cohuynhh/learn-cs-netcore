using System.ComponentModel.DataAnnotations;

namespace ef02.Model
{
    public class User
    {
        [Key]
        public int UserId {set; get;}

        [StringLength(20)]
        public string UserName {set; get;}
    }
}