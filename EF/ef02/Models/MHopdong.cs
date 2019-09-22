using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("m_hopdong")]
    public partial class MHopdong
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("User_create")]
        public int? UserCreate { get; set; }
        [Column("khachhang")]
        public int? Khachhang { get; set; }
        [Column("giatrihopdong")]
        public int? Giatrihopdong { get; set; }
        [Column("tinhtranghopdong")]
        public int Tinhtranghopdong { get; set; }
        [Column("khoa")]
        public bool? Khoa { get; set; }
        [Column("loaihd")]
        public int? Loaihd { get; set; }
        [Column("lock")]
        public bool? Lock { get; set; }
        [Column("donvithicong")]
        public int? Donvithicong { get; set; }
        [Column("ghichucongno", TypeName = "ntext")]
        public string Ghichucongno { get; set; }
        [Column("phathopdong")]
        public int? Phathopdong { get; set; }
        [Column("phatsinh")]
        public int? Phatsinh { get; set; }
        [Column("chietkhau")]
        public float? Chietkhau { get; set; }
        [Column("parent")]
        public int? Parent { get; set; }
        [Column("tongphieuthu")]
        public int? Tongphieuthu { get; set; }
        [Column("tc_thicong_value")]
        public int? TcThicongValue { get; set; }
        [Column("tc_vatlieu_value")]
        public int? TcVatlieuValue { get; set; }
        [Column("tc_thicong_ngaycapnhat")]
        public long? TcThicongNgaycapnhat { get; set; }
        [Column("tc_thicong_ngayketthuc")]
        public long? TcThicongNgayketthuc { get; set; }
        [Column("tc_thicong_khoa")]
        public bool? TcThicongKhoa { get; set; }
        [Column("tc_thicong_noidung", TypeName = "ntext")]
        public string TcThicongNoidung { get; set; }
        [Column("tc_vatlieu_ngaycapnhat")]
        public long? TcVatlieuNgaycapnhat { get; set; }
        [Column("tc_vatlieu_ngayketthuc")]
        public long? TcVatlieuNgayketthuc { get; set; }
        [Column("tc_vatlieu_khoa")]
        public bool? TcVatlieuKhoa { get; set; }
        [Column("tc_vatlieu_noidung", TypeName = "ntext")]
        public string TcVatlieuNoidung { get; set; }
        [Column("songaycon")]
        public int? Songaycon { get; set; }
        [Column("ngaycapnhatcuoi")]
        public long? Ngaycapnhatcuoi { get; set; }
        [Column("logs", TypeName = "ntext")]
        public string Logs { get; set; }
        [Column("pin")]
        public bool? Pin { get; set; }
        [Column("tenhd")]
        [StringLength(250)]
        public string Tenhd { get; set; }
        [StringLength(50)]
        public string CodeContract { get; set; }
        [Column("search")]
        [StringLength(600)]
        public string Search { get; set; }
        [Column("datestart", TypeName = "date")]
        public DateTime? Datestart { get; set; }
        [Column("datefinish", TypeName = "date")]
        public DateTime? Datefinish { get; set; }
        [Column("chutri")]
        public int? Chutri { get; set; }
        [Column("money_tongthu")]
        public int? MoneyTongthu { get; set; }
        [Column("money_tongchi")]
        public int? MoneyTongchi { get; set; }
        [Column("money_conlai")]
        public int? MoneyConlai { get; set; }
        [Column("khachhangs")]
        [StringLength(80)]
        public string Khachhangs { get; set; }
        [Column("workers")]
        [StringLength(2000)]
        public string Workers { get; set; }
        [Column("giahan")]
        public int? Giahan { get; set; }
        [Column("complete")]
        public int? Complete { get; set; }
        [Column("completestring")]
        [StringLength(500)]
        public string Completestring { get; set; }
        [Column("completelogs")]
        [StringLength(4000)]
        public string Completelogs { get; set; }
        [Column("completepredic")]
        public int? Completepredic { get; set; }
        [Column("tongsongay")]
        public int? Tongsongay { get; set; }
        [Column("completepredicbydate")]
        public int? Completepredicbydate { get; set; }
        [Column("capnhatcuoi")]
        [StringLength(2000)]
        public string Capnhatcuoi { get; set; }
        [Column("vatlieu_yeucau_vp")]
        public int? VatlieuYeucauVp { get; set; }
        [Column("vatlieu_thieu_vp")]
        public int? VatlieuThieuVp { get; set; }
        [Column("vatlieu_yeucau_x")]
        public int? VatlieuYeucauX { get; set; }
        [Column("vatlieu_thieu_x")]
        public int? VatlieuThieuX { get; set; }
        [Column("vatlieu_chiphi")]
        public int? VatlieuChiphi { get; set; }
        [Column("vatlieu_chiphi_dutoantong")]
        public int? VatlieuChiphiDutoantong { get; set; }
        [Column("vatlieu_chiphi_vatlieu")]
        public int? VatlieuChiphiVatlieu { get; set; }
        [Column("vatlieu_chiphi_phukienthietbi")]
        public int? VatlieuChiphiPhukienthietbi { get; set; }
        [Column("vatlieu_canchi_vl")]
        public int? VatlieuCanchiVl { get; set; }
        [Column("vatlieu_canchi_pk")]
        public int? VatlieuCanchiPk { get; set; }
        [Column("datecreate", TypeName = "datetime")]
        public DateTime? Datecreate { get; set; }
        [Column("fullcheck")]
        public bool? Fullcheck { get; set; }
        [Column("date_giaohang", TypeName = "date")]
        public DateTime? DateGiaohang { get; set; }

        [ForeignKey("Khachhang")]
        [InverseProperty("MHopdong")]
        public virtual MKhachhang KhachhangNavigation { get; set; }
        public virtual ContractType LoaihdNavigation { get; set; }
        public virtual ContractStates TinhtranghopdongNavigation { get; set; }
        [ForeignKey("UserCreate")]
        [InverseProperty("MHopdong")]
        public virtual Nhanvienit UserCreateNavigation { get; set; }
    }
}
