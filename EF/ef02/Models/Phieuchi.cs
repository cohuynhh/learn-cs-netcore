using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("phieuchi")]
    public partial class Phieuchi
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("quyenso")]
        public int? Quyenso { get; set; }
        [Column("so")]
        public int So { get; set; }
        [Column("m_nhanvienlap")]
        public int? MNhanvienlap { get; set; }
        [Column("m_daxacnhan")]
        public bool? MDaxacnhan { get; set; }
        [Column("loaikhoanchi")]
        public int? Loaikhoanchi { get; set; }
        [Column("nguoinhan")]
        public int? Nguoinhan { get; set; }
        [Column("hopdong")]
        public int? Hopdong { get; set; }
        [Column("kieuphieu")]
        public int? Kieuphieu { get; set; }
        [Column("ngays")]
        public int? Ngays { get; set; }
        [Column("thangs")]
        public int? Thangs { get; set; }
        [Column("nams")]
        public int? Nams { get; set; }
        [Column("co")]
        [StringLength(10)]
        public string Co { get; set; }
        [Column("no")]
        [StringLength(10)]
        public string No { get; set; }
        [Column("phanloai")]
        [StringLength(300)]
        public string Phanloai { get; set; }
        [Column("sotien")]
        public long? Sotien { get; set; }
        [Column("idlink")]
        public int? Idlink { get; set; }
        [Column("ngayduyet", TypeName = "datetime")]
        public DateTime? Ngayduyet { get; set; }
        [Column("nguoiduyet")]
        public int? Nguoiduyet { get; set; }
        [Column("kemtheo")]
        [StringLength(500)]
        public string Kemtheo { get; set; }
        [Column("m_ghichu")]
        [StringLength(1000)]
        public string MGhichu { get; set; }
        [Column("lydo")]
        [StringLength(1000)]
        public string Lydo { get; set; }
        [Column("logchange")]
        public string Logchange { get; set; }
        [Column("ngaychi_new", TypeName = "datetime")]
        public DateTime? NgaychiNew { get; set; }
        [Column("ngaylap_new", TypeName = "datetime")]
        public DateTime? NgaylapNew { get; set; }
        [Column("search")]
        [StringLength(500)]
        public string Search { get; set; }
        [Column("ton")]
        public long? Ton { get; set; }
    }
}
