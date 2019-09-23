using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("m_mgs")]
    public partial class MMgs
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("nhanvien")]
        public int? Nhanvien { get; set; }
        [Column("dadoc")]
        public bool? Dadoc { get; set; }
        [Column("ngaygio", TypeName = "datetime")]
        public DateTime? Ngaygio { get; set; }
        [Column("nguoigui")]
        public int? Nguoigui { get; set; }
        [Column("idthamkhao")]
        public int? Idthamkhao { get; set; }
        [Column("kieuthongbao")]
        public int? Kieuthongbao { get; set; }
        [Column("detailid")]
        public int? Detailid { get; set; }
        [Column("noidung")]
        [StringLength(400)]
        public string Noidung { get; set; }

        [ForeignKey("Nguoigui")]
        [InverseProperty("MMgsNguoiguiNavigation")]
        public virtual Nhanvienit NguoiguiNavigation { get; set; }
        [ForeignKey("Nhanvien")]
        [InverseProperty("MMgsNhanvienNavigation")]
        public virtual Nhanvienit NhanvienNavigation { get; set; }
    }
}
