using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("m_nhapxuat_item")]
    public partial class MNhapxuatItem
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("sodexuat")]
        public float? Sodexuat { get; set; }
        [Column("denghi")]
        public int? Denghi { get; set; }
        [Column("gia")]
        public int? Gia { get; set; }
        [Column("chietkhau")]
        public float? Chietkhau { get; set; }
        [Column("idsanpham")]
        public int? Idsanpham { get; set; }
        [Column("lock")]
        public bool? Lock { get; set; }
        [Column("huy")]
        public bool? Huy { get; set; }
        [Column("ghichu")]
        [StringLength(300)]
        public string Ghichu { get; set; }
    }
}
