using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("m_chamcong")]
    public partial class MChamcong
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("ngay")]
        public int? Ngay { get; set; }
        [Column("thang")]
        public int? Thang { get; set; }
        [Column("nam")]
        public int? Nam { get; set; }
        [Column("nhanvien")]
        public int? Nhanvien { get; set; }
        [Column("sang")]
        public bool? Sang { get; set; }
        [Column("chieu")]
        public bool? Chieu { get; set; }
        [Column("lock")]
        public bool? Lock { get; set; }
        [Column("lydo", TypeName = "ntext")]
        public string Lydo { get; set; }
    }
}
