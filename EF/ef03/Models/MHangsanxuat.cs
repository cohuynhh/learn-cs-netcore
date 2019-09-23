using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("m_hangsanxuat")]
    public partial class MHangsanxuat
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("tenhang")]
        [StringLength(255)]
        public string Tenhang { get; set; }
        [Column("chietkhau", TypeName = "ntext")]
        public string Chietkhau { get; set; }
        [Column("lienhe", TypeName = "ntext")]
        public string Lienhe { get; set; }
        [Column("dienthoai", TypeName = "ntext")]
        public string Dienthoai { get; set; }
        [Column("lock")]
        public bool? Lock { get; set; }
    }
}
