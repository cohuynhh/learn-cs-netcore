using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("m_kehoachchithanhtoan")]
    public partial class MKehoachchithanhtoan
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("ngaytao")]
        public long? Ngaytao { get; set; }
        [Column("ngaydukienchi")]
        public long? Ngaydukienchi { get; set; }
        [Column("tieude", TypeName = "ntext")]
        public string Tieude { get; set; }
        [Column("lydo", TypeName = "ntext")]
        public string Lydo { get; set; }
        [Column("nguoidexuat")]
        public int? Nguoidexuat { get; set; }
        [Column("nguoitao")]
        public int? Nguoitao { get; set; }
        [Column("chapnhan")]
        public bool? Chapnhan { get; set; }
        [Column("tongtien")]
        public int? Tongtien { get; set; }
        [Column("quanly1")]
        public int? Quanly1 { get; set; }
        [Column("quanly2")]
        public int? Quanly2 { get; set; }
        [Column("idthamkhao")]
        public int? Idthamkhao { get; set; }
        [Column("kieuthamkhao")]
        public int? Kieuthamkhao { get; set; }
        [Column("idnguoiduocchi")]
        public int? Idnguoiduocchi { get; set; }
    }
}
