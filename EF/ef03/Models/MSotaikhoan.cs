using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("m_sotaikhoan")]
    public partial class MSotaikhoan
    {
        [Column("so")]
        [StringLength(10)]
        public string So { get; set; }
        [Column("diengiai")]
        [StringLength(500)]
        public string Diengiai { get; set; }
        [Column("cap")]
        public int? Cap { get; set; }
        [Column("socha")]
        [StringLength(10)]
        public string Socha { get; set; }
        [Column("loai")]
        public int? Loai { get; set; }
        [Column("diengiailoai")]
        [StringLength(200)]
        public string Diengiailoai { get; set; }
    }
}
