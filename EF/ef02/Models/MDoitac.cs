using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("m_doitac")]
    public partial class MDoitac
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("dienthoai")]
        [StringLength(255)]
        public string Dienthoai { get; set; }
        [Column("fax")]
        [StringLength(255)]
        public string Fax { get; set; }
        [Column("web")]
        [StringLength(255)]
        public string Web { get; set; }
        [Column("email")]
        [StringLength(255)]
        public string Email { get; set; }
        [Column("mst")]
        [StringLength(50)]
        public string Mst { get; set; }
        [Column("gpkd")]
        [StringLength(50)]
        public string Gpkd { get; set; }
        [Column("linhvuc", TypeName = "ntext")]
        public string Linhvuc { get; set; }
        [Column("thongtin", TypeName = "ntext")]
        public string Thongtin { get; set; }
        [Column("loai")]
        public int? Loai { get; set; }
        [Column("diachi", TypeName = "ntext")]
        public string Diachi { get; set; }
        [Column("lock")]
        public bool? Lock { get; set; }
        [Column("congno")]
        public long? Congno { get; set; }
        [Column("ten")]
        [StringLength(250)]
        public string Ten { get; set; }
        [Column("shortname")]
        [StringLength(20)]
        public string Shortname { get; set; }
        [Column("search")]
        [StringLength(500)]
        public string Search { get; set; }
        [Column("ngay", TypeName = "date")]
        public DateTime? Ngay { get; set; }
        [Column("nguoitao")]
        public int? Nguoitao { get; set; }
    }
}
