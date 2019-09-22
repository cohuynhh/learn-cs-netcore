using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("m_ghichu")]
    public partial class MGhichu
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("kieunhacviec")]
        public int? Kieunhacviec { get; set; }
        [Column("nhanvien")]
        public int? Nhanvien { get; set; }
        [Column("active")]
        public bool? Active { get; set; }
        [Column("idhopdong")]
        public int? Idhopdong { get; set; }
        [Column("idevent")]
        public int? Idevent { get; set; }
        [Column("kieu")]
        public int? Kieu { get; set; }
        [Column("ngaytaoghichu", TypeName = "datetime")]
        public DateTime? Ngaytaoghichu { get; set; }
        [Column("ngaynhacghichu", TypeName = "datetime")]
        public DateTime? Ngaynhacghichu { get; set; }
        [Column("ten")]
        [StringLength(350)]
        public string Ten { get; set; }
        [Column("noidung")]
        [StringLength(2500)]
        public string Noidung { get; set; }
        [Column("search")]
        [StringLength(2500)]
        public string Search { get; set; }
        [Column("ngaycapnhatghichu", TypeName = "datetime")]
        public DateTime? Ngaycapnhatghichu { get; set; }

        [ForeignKey("Nhanvien")]
        [InverseProperty("MGhichu")]
        public virtual Nhanvienit NhanvienNavigation { get; set; }
    }
}
