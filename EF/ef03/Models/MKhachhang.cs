using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("m_khachhang")]
    public partial class MKhachhang
    {
        public MKhachhang()
        {
            MHopdong = new HashSet<MHopdong>();
        }

        [Column("ID")]
        public int Id { get; set; }
        [Column("ngayden")]
        public long? Ngayden { get; set; }
        [Column("loai")]
        public int? Loai { get; set; }
        [Column("nhanviencapnhat")]
        public int? Nhanviencapnhat { get; set; }
        [Column("lock")]
        public bool? Lock { get; set; }
        [Column("iddoitac")]
        public int? Iddoitac { get; set; }
        [Column("hoten")]
        [StringLength(100)]
        public string Hoten { get; set; }
        [Column("dienthoai")]
        [StringLength(100)]
        public string Dienthoai { get; set; }
        [Column("email")]
        [StringLength(100)]
        public string Email { get; set; }
        [Column("diachi")]
        [StringLength(255)]
        public string Diachi { get; set; }
        [Column("ghichu")]
        [StringLength(500)]
        public string Ghichu { get; set; }
        [Column("search")]
        [StringLength(500)]
        public string Search { get; set; }
        [Column("ngays")]
        public int? Ngays { get; set; }
        [Column("thangs")]
        public int? Thangs { get; set; }
        [Column("nams")]
        public int? Nams { get; set; }
        [Column("searchname")]
        [StringLength(100)]
        public string Searchname { get; set; }
        [Column("idlink")]
        public int? Idlink { get; set; }

        [InverseProperty("KhachhangNavigation")]
        public virtual ICollection<MHopdong> MHopdong { get; set; }
    }
}
