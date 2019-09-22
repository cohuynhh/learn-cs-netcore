using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("kt_ketoanmay")]
    public partial class KtKetoanmay
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("thang")]
        public int? Thang { get; set; }
        [Column("nam")]
        public int? Nam { get; set; }
        [Column("ngayghiso", TypeName = "date")]
        public DateTime? Ngayghiso { get; set; }
        [Column("idkhachhang")]
        public int? Idkhachhang { get; set; }
        [Column("tenkh")]
        [StringLength(50)]
        public string Tenkh { get; set; }
        [Column("iddoitac")]
        public int? Iddoitac { get; set; }
        [Column("tendt")]
        [StringLength(50)]
        public string Tendt { get; set; }
        [Column("diengiai")]
        [StringLength(500)]
        public string Diengiai { get; set; }
        [Column("co")]
        [StringLength(10)]
        public string Co { get; set; }
        [Column("no")]
        [StringLength(10)]
        public string No { get; set; }
        [Column("sotien")]
        public long? Sotien { get; set; }
        [Column("islink")]
        public bool? Islink { get; set; }
        [Column("lock")]
        public bool? Lock { get; set; }
        [Column("kieu")]
        public int? Kieu { get; set; }
        [Column("idhopdong")]
        public int? Idhopdong { get; set; }
        [Column("idphieuthuchi")]
        public int? Idphieuthuchi { get; set; }
        [Column("idsanpham")]
        public int? Idsanpham { get; set; }
        [Column("idphieunhap")]
        public int? Idphieunhap { get; set; }
        [Column("iditemphieunhap")]
        public int? Iditemphieunhap { get; set; }
        [Column("usercreate")]
        public int? Usercreate { get; set; }
        [Column("objectlink")]
        public int? Objectlink { get; set; }
    }
}
