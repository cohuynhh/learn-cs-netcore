using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("nhanvienit")]
    public partial class Nhanvienit
    {
        public Nhanvienit()
        {
            AclPermissions = new HashSet<AclPermissions>();
            MEventNguoinhanNavigation = new HashSet<MEvent>();
            MEventNguoitaoNavigation = new HashSet<MEvent>();
            MFiledata = new HashSet<MFiledata>();
            MGhichu = new HashSet<MGhichu>();
            MHopdong = new HashSet<MHopdong>();
            MMgsNguoiguiNavigation = new HashSet<MMgs>();
            MMgsNhanvienNavigation = new HashSet<MMgs>();
        }

        [Column("ID")]
        public int Id { get; set; }
        [Column("pass", TypeName = "ntext")]
        public string Pass { get; set; }
        [Column("hokhau", TypeName = "ntext")]
        public string Hokhau { get; set; }
        [Column("noio", TypeName = "ntext")]
        public string Noio { get; set; }
        [Column("chucvu", TypeName = "ntext")]
        public string Chucvu { get; set; }
        [Column("chuyenmon", TypeName = "ntext")]
        public string Chuyenmon { get; set; }
        [Column("dienthoai", TypeName = "ntext")]
        public string Dienthoai { get; set; }
        [Column("skype", TypeName = "ntext")]
        public string Skype { get; set; }
        [Column("yahoo", TypeName = "ntext")]
        public string Yahoo { get; set; }
        [Column("email", TypeName = "ntext")]
        public string Email { get; set; }
        [Column("loai")]
        public int? Loai { get; set; }
        [Column("ngaysinh", TypeName = "date")]
        public DateTime? Ngaysinh { get; set; }
        [Column("ngayvaoct", TypeName = "date")]
        public DateTime? Ngayvaoct { get; set; }
        [Column("gioitinh")]
        public bool? Gioitinh { get; set; }
        [Column("bophan")]
        public int? Bophan { get; set; }
        [Column("active")]
        public int? Active { get; set; }
        [Column("lock")]
        public bool? Lock { get; set; }
        [Column("hinhanh", TypeName = "image")]
        public byte[] Hinhanh { get; set; }
        [Column("mucluong")]
        public int? Mucluong { get; set; }
        [Column("online")]
        public bool? Online { get; set; }
        [Column("lastonline")]
        public long? Lastonline { get; set; }
        [Column("anhnho", TypeName = "image")]
        public byte[] Anhnho { get; set; }
        [Column("luongphucap")]
        public int? Luongphucap { get; set; }
        [Column("luongtrachnhiem")]
        public int? Luongtrachnhiem { get; set; }
        [Column("motacongviec", TypeName = "ntext")]
        public string Motacongviec { get; set; }
        [Column("iplogs")]
        [StringLength(200)]
        public string Iplogs { get; set; }
        [Column("countmsg")]
        public int? Countmsg { get; set; }
        [Column("per_iscongtacvien_it")]
        public bool? PerIscongtacvienIt { get; set; }
        [StringLength(100)]
        public string FullName { get; set; }
        [Column("hoten")]
        [StringLength(100)]
        public string Hoten { get; set; }
        [Column("lasttimeonline", TypeName = "datetime")]
        public DateTime? Lasttimeonline { get; set; }
        [Column("countnotemgs")]
        public int? Countnotemgs { get; set; }
        [Column("countIM_notread")]
        public bool? CountImNotread { get; set; }
        [Column("ahdemail")]
        [StringLength(350)]
        public string Ahdemail { get; set; }

        [InverseProperty("User")]
        public virtual ICollection<AclPermissions> AclPermissions { get; set; }
        [InverseProperty("NguoinhanNavigation")]
        public virtual ICollection<MEvent> MEventNguoinhanNavigation { get; set; }
        [InverseProperty("NguoitaoNavigation")]
        public virtual ICollection<MEvent> MEventNguoitaoNavigation { get; set; }
        [InverseProperty("NhanvienNavigation")]
        public virtual ICollection<MFiledata> MFiledata { get; set; }
        [InverseProperty("NhanvienNavigation")]
        public virtual ICollection<MGhichu> MGhichu { get; set; }
        [InverseProperty("UserCreateNavigation")]
        public virtual ICollection<MHopdong> MHopdong { get; set; }
        [InverseProperty("NguoiguiNavigation")]
        public virtual ICollection<MMgs> MMgsNguoiguiNavigation { get; set; }
        [InverseProperty("NhanvienNavigation")]
        public virtual ICollection<MMgs> MMgsNhanvienNavigation { get; set; }
    }
}
