using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    public partial class Sanpham
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("MOTA", TypeName = "ntext")]
        public string Mota { get; set; }
        [Column("NHOM")]
        public int? Nhom { get; set; }
        [Column("HANG")]
        public int? Hang { get; set; }
        [Column("DV")]
        public int? Dv { get; set; }
        [Column("anhnho")]
        [MaxLength(8000)]
        public byte[] Anhnho { get; set; }
        [Column("HINH")]
        public byte[] Hinh { get; set; }
        [Column("PHANLOAI")]
        public int? Phanloai { get; set; }
        [Column("lock")]
        public bool? Lock { get; set; }
        [Column("dongia")]
        public int? Dongia { get; set; }
        [Column("nhanvien")]
        public int? Nhanvien { get; set; }
        [Column("ngaycapnhat", TypeName = "date")]
        public DateTime? Ngaycapnhat { get; set; }
        [Column("tungnhap")]
        public bool? Tungnhap { get; set; }
        [Column("haydung")]
        public bool? Haydung { get; set; }
        [Column("kiem")]
        public bool? Kiem { get; set; }
        [Column("searchluu")]
        public string Searchluu { get; set; }
        [Column("id_bx")]
        public int? IdBx { get; set; }
        [Column("sizepic")]
        public double? Sizepic { get; set; }
        [Column("banle")]
        public bool? Banle { get; set; }
        [Column("lasselect", TypeName = "datetime")]
        public DateTime? Lasselect { get; set; }
        [Column("search")]
        [StringLength(500)]
        public string Search { get; set; }
        [Column("MA")]
        [StringLength(250)]
        public string Ma { get; set; }
        [Column("QUOCGIA")]
        [StringLength(50)]
        public string Quocgia { get; set; }
        [Column("TEN")]
        [StringLength(400)]
        public string Ten { get; set; }
        [Column("chietkhau")]
        public int? Chietkhau { get; set; }
        [Column("metatitle")]
        [StringLength(350)]
        public string Metatitle { get; set; }
        [Column("metakeywords")]
        [StringLength(250)]
        public string Metakeywords { get; set; }
        [Column("url_bx")]
        [StringLength(500)]
        public string UrlBx { get; set; }
        [Column("metades")]
        [StringLength(500)]
        public string Metades { get; set; }
        [Column("C_Brief")]
        [StringLength(2500)]
        public string CBrief { get; set; }
        [Column("C_Active")]
        public bool? CActive { get; set; }
    }
}
