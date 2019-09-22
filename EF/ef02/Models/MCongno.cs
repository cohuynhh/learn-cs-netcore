using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("m_congno")]
    public partial class MCongno
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("doitac")]
        public int? Doitac { get; set; }
        [Column("ngay")]
        public long? Ngay { get; set; }
        [Column("sotien")]
        public long? Sotien { get; set; }
        [Column("phatsinhtang")]
        public bool? Phatsinhtang { get; set; }
        [Column("hide")]
        public bool? Hide { get; set; }
        [Column("lock")]
        public bool? Lock { get; set; }
        [Column("idphieuthuchi")]
        public int? Idphieuthuchi { get; set; }
        [Column("idhopdong")]
        public int? Idhopdong { get; set; }
        [Column("iddonhang")]
        public int? Iddonhang { get; set; }
        [Column("nhom")]
        public int? Nhom { get; set; }
        [Column("tonquy")]
        public long? Tonquy { get; set; }
        [Column("nguoitao")]
        [StringLength(50)]
        public string Nguoitao { get; set; }
        [Column("idnguoitao")]
        public int? Idnguoitao { get; set; }
        [Column("noidung")]
        [StringLength(300)]
        public string Noidung { get; set; }
        [Column("datecreate", TypeName = "datetime")]
        public DateTime? Datecreate { get; set; }
    }
}
