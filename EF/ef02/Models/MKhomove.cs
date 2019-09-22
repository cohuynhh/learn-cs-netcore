using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("m_khomove")]
    public partial class MKhomove
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("idkho")]
        public int Idkho { get; set; }
        [Column("idvl")]
        public int Idvl { get; set; }
        [Column("kfrom")]
        public int Kfrom { get; set; }
        [Column("kto")]
        public int? Kto { get; set; }
        [Column("soluong")]
        public float Soluong { get; set; }
        [Column("ngay", TypeName = "date")]
        public DateTime Ngay { get; set; }
        [Column("lock")]
        public bool Lock { get; set; }
        [Column("nv")]
        public int? Nv { get; set; }
    }
}
