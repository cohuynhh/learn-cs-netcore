using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("m_kho")]
    public partial class MKho
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("IDsp")]
        public int? Idsp { get; set; }
        public float? Soluong { get; set; }
        [Column("lock")]
        public bool? Lock { get; set; }
        [Column("tong")]
        public float? Tong { get; set; }
        [Column("khovp")]
        public float? Khovp { get; set; }
        [Column("khox")]
        public float? Khox { get; set; }
        [Column("khodungcux")]
        public float? Khodungcux { get; set; }
        [Column("khodungcuvp")]
        public float? Khodungcuvp { get; set; }
        [Column("ngaycapnhat", TypeName = "date")]
        public DateTime? Ngaycapnhat { get; set; }
    }
}
