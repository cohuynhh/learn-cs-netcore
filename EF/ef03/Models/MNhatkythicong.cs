using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("m_nhatkythicong")]
    public partial class MNhatkythicong
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("ngay")]
        public long? Ngay { get; set; }
        [Column("iduser")]
        public int? Iduser { get; set; }
        [Column("idhopdong")]
        public int? Idhopdong { get; set; }
        [Column("noidung")]
        [StringLength(1000)]
        public string Noidung { get; set; }
        [Column("logs", TypeName = "ntext")]
        public string Logs { get; set; }
    }
}
