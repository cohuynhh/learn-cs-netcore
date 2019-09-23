using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("m_baocao_vatlieu")]
    public partial class MBaocaoVatlieu
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("idvatlieu")]
        public int? Idvatlieu { get; set; }
        [Column("soluong")]
        public float? Soluong { get; set; }
        [Column("ton")]
        public float? Ton { get; set; }
        [Column("nhap")]
        public float? Nhap { get; set; }
        [Column("hopdong")]
        public int Hopdong { get; set; }
        [Column("kieu")]
        public int? Kieu { get; set; }
        [Column("xuat")]
        public float? Xuat { get; set; }
        [Column("lock")]
        public bool? Lock { get; set; }
        [Column("ghichu")]
        [StringLength(1000)]
        public string Ghichu { get; set; }
    }
}
