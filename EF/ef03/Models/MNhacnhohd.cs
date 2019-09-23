using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("m_nhacnhohd")]
    public partial class MNhacnhohd
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("hopdong")]
        public int Hopdong { get; set; }
        [Column("nhanvien")]
        public int? Nhanvien { get; set; }
        [Column("ngay")]
        public long? Ngay { get; set; }
        [Column("kieu")]
        public int? Kieu { get; set; }
        [Column("ngaygui", TypeName = "datetime")]
        public DateTime? Ngaygui { get; set; }
        [Column("noidung")]
        [StringLength(3000)]
        public string Noidung { get; set; }
    }
}
