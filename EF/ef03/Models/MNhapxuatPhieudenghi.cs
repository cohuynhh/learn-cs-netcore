using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("m_nhapxuat_phieudenghi")]
    public partial class MNhapxuatPhieudenghi
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("nguoidexuat")]
        public int? Nguoidexuat { get; set; }
        [Column("kiemsoat")]
        public int? Kiemsoat { get; set; }
        [Column("ngaydexuat_")]
        public long? Ngaydexuat { get; set; }
        [Column("ngayketthuc_")]
        public long? Ngayketthuc { get; set; }
        [Column("xoa_xacnhan")]
        public bool? XoaXacnhan { get; set; }
        [Column("nguoilapphieu")]
        public int? Nguoilapphieu { get; set; }
        [Column("nguoihuy")]
        public int? Nguoihuy { get; set; }
        [Column("xoa_lydohuy", TypeName = "ntext")]
        public string XoaLydohuy { get; set; }
        [Column("xoa_huydonhang")]
        public bool? XoaHuydonhang { get; set; }
        [Column("lock")]
        public bool? Lock { get; set; }
        [Column("hopdong")]
        public int? Hopdong { get; set; }
        [Column("khachhang")]
        public int? Khachhang { get; set; }
        [Column("thihanh")]
        public bool? Thihanh { get; set; }
        [Column("ghichu", TypeName = "text")]
        public string Ghichu { get; set; }
        [Column("nguoinhan")]
        public int? Nguoinhan { get; set; }
        [Column("thanhtoan", TypeName = "ntext")]
        public string Thanhtoan { get; set; }
        [Column("diadiemgiao", TypeName = "ntext")]
        public string Diadiemgiao { get; set; }
        [Column("nhap")]
        public byte? Nhap { get; set; }
        [Column("so")]
        [StringLength(10)]
        public string So { get; set; }
        [Column("tieude")]
        [StringLength(300)]
        public string Tieude { get; set; }
        [Column("tenkhachhang")]
        [StringLength(100)]
        public string Tenkhachhang { get; set; }
        [Column("tenhopdong")]
        [StringLength(300)]
        public string Tenhopdong { get; set; }
        [Column("tennguoinhan")]
        [StringLength(100)]
        public string Tennguoinhan { get; set; }
        [Column("tennguoidexuat")]
        [StringLength(100)]
        public string Tennguoidexuat { get; set; }
        [Column("tenkiemsoat")]
        [StringLength(100)]
        public string Tenkiemsoat { get; set; }
        [Column("diengiaigia")]
        [StringLength(500)]
        public string Diengiaigia { get; set; }
        [Column("tennguoilapphieu")]
        [StringLength(100)]
        public string Tennguoilapphieu { get; set; }
        [Column("search")]
        [StringLength(500)]
        public string Search { get; set; }
        [Column("tinnhancuoi")]
        [StringLength(300)]
        public string Tinnhancuoi { get; set; }
        [Column("tongtien")]
        public int? Tongtien { get; set; }
        [Column("tongtiensauchietkhau")]
        public int? Tongtiensauchietkhau { get; set; }
        [Column("tongtienchietkhau")]
        public int? Tongtienchietkhau { get; set; }
        [Column("iddoitac")]
        public int? Iddoitac { get; set; }
        [Column("tendt")]
        [StringLength(150)]
        public string Tendt { get; set; }
        [Column("ngaydexuat", TypeName = "date")]
        public DateTime? Ngaydexuat1 { get; set; }
        [Column("ngayketthuc", TypeName = "date")]
        public DateTime? Ngayketthuc1 { get; set; }
        [Column("co")]
        [StringLength(10)]
        public string Co { get; set; }
        [Column("no")]
        [StringLength(10)]
        public string No { get; set; }
        [Column("chiphivanchuyen")]
        public int? Chiphivanchuyen { get; set; }
        [Column("kho")]
        public int? Kho { get; set; }
    }
}
