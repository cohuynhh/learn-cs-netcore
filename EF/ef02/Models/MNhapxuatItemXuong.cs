using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("m_nhapxuat_item_xuong")]
    public partial class MNhapxuatItemXuong
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("sodexuat")]
        public float? Sodexuat { get; set; }
        [Column("ghichu", TypeName = "ntext")]
        public string Ghichu { get; set; }
        [Column("denghi")]
        public int? Denghi { get; set; }
        [Column("gia")]
        public int? Gia { get; set; }
        [Column("chietkhau")]
        public float? Chietkhau { get; set; }
        [Column("idsanpham")]
        public int? Idsanpham { get; set; }
        [Column("idthamkhao")]
        public long? Idthamkhao { get; set; }
        [Column("vaophieunhap")]
        public bool? Vaophieunhap { get; set; }
        [Column("idlistitemdenghi", TypeName = "ntext")]
        public string Idlistitemdenghi { get; set; }
        [Column("lock")]
        public bool? Lock { get; set; }
        [Column("huy")]
        public bool? Huy { get; set; }
    }
}
