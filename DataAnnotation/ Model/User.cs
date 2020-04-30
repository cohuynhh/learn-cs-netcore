using System.ComponentModel.DataAnnotations;
namespace DataAnnotation.Model
{
    public class User
    {
        [Required (ErrorMessage="Cần thiết lập {0}")]
        [StringLength (100,MinimumLength=3, ErrorMessage="Tên từ 3 đến  100 ký tự")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Range(18,99, ErrorMessage="Tuổi từ 18 đến 99")]
        public int Age { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string PhoneNumber {set; get;}
        
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

    }
}