using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("in_phieuxuat")]
    public partial class InPhieuxuat
    {
        [Column("tendenghixuat", TypeName = "ntext")]
        public string Tendenghixuat { get; set; }
        [Column("congtrinh", TypeName = "ntext")]
        public string Congtrinh { get; set; }
        [Column("hopdong", TypeName = "ntext")]
        public string Hopdong { get; set; }
        [Column("khachhang", TypeName = "ntext")]
        public string Khachhang { get; set; }
        [Column("noixuat", TypeName = "ntext")]
        public string Noixuat { get; set; }
        [Column("nguoinhan", TypeName = "ntext")]
        public string Nguoinhan { get; set; }
        [Column("phanloai", TypeName = "ntext")]
        public string Phanloai { get; set; }
        [Column("tenphukienthietbi", TypeName = "ntext")]
        public string Tenphukienthietbi { get; set; }
        [Column("mahang", TypeName = "ntext")]
        public string Mahang { get; set; }
        [Column("hangsx", TypeName = "ntext")]
        public string Hangsx { get; set; }
        [Column("dvt", TypeName = "ntext")]
        public string Dvt { get; set; }
        [Column("soluong", TypeName = "ntext")]
        public string Soluong { get; set; }
        [Column("ghichu", TypeName = "ntext")]
        public string Ghichu { get; set; }
        [Column("ID")]
        public int Id { get; set; }
    }
}
