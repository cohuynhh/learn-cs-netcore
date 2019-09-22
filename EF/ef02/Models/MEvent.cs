using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("m_event")]
    public partial class MEvent
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("nguoitao")]
        public int? Nguoitao { get; set; }
        [Column("ngaytao")]
        public long? Ngaytao { get; set; }
        [Column("batdau")]
        public long? Batdau { get; set; }
        [Column("ketthuc")]
        public long? Ketthuc { get; set; }
        [Column("ngaynghiemthu")]
        public long? Ngaynghiemthu { get; set; }
        [Column("ngaynhan")]
        public long? Ngaynhan { get; set; }
        [Column("mota", TypeName = "ntext")]
        public string Mota { get; set; }
        [Column("kieu")]
        public int? Kieu { get; set; }
        [Column("idthamkhao")]
        public int? Idthamkhao { get; set; }
        [Column("nguoinhan")]
        public int? Nguoinhan { get; set; }
        [Column("accept")]
        public bool? Accept { get; set; }
        [Column("finished")]
        public bool? Finished { get; set; }
        [Column("diem")]
        public int? Diem { get; set; }
        [Column("name")]
        [StringLength(250)]
        public string Name { get; set; }
        [Column("danhgia")]
        [StringLength(250)]
        public string Danhgia { get; set; }
        [Column("complete")]
        public int? Complete { get; set; }
        [Column("datecreate", TypeName = "datetime")]
        public DateTime? Datecreate { get; set; }
        [Column("datestart", TypeName = "datetime")]
        public DateTime? Datestart { get; set; }
        [Column("datefinish", TypeName = "datetime")]
        public DateTime? Datefinish { get; set; }
        [Column("dateacceptance", TypeName = "datetime")]
        public DateTime? Dateacceptance { get; set; }
        [Column("dateaccept", TypeName = "datetime")]
        public DateTime? Dateaccept { get; set; }

        [ForeignKey("Nguoinhan")]
        [InverseProperty("MEventNguoinhanNavigation")]
        public virtual Nhanvienit NguoinhanNavigation { get; set; }
        [ForeignKey("Nguoitao")]
        [InverseProperty("MEventNguoitaoNavigation")]
        public virtual Nhanvienit NguoitaoNavigation { get; set; }
    }
}
