using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("m_bangluong")]
    public partial class MBangluong
    {
        [Column("nhanvien")]
        public int? Nhanvien { get; set; }
        [Column("thang")]
        public int? Thang { get; set; }
        [Column("nam")]
        public int? Nam { get; set; }
        [Column("sogiolamthem")]
        public double? Sogiolamthem { get; set; }
        [Column("diengiaisogiolamthem", TypeName = "ntext")]
        public string Diengiaisogiolamthem { get; set; }
        [Column("tamung")]
        public double? Tamung { get; set; }
        [Column("phat")]
        public double? Phat { get; set; }
        [Column("diengiaiphat", TypeName = "ntext")]
        public string Diengiaiphat { get; set; }
        [Column("ID")]
        public int Id { get; set; }
        [Column("thuong")]
        public double? Thuong { get; set; }
        [Column("cong")]
        public double? Cong { get; set; }
        [Column("lock")]
        public bool? Lock { get; set; }
    }
}
