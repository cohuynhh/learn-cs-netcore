using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("kt_ccdc")]
    public partial class KtCcdc
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("ngayduavaosudung", TypeName = "date")]
        public DateTime? Ngayduavaosudung { get; set; }
        [Column("ngayphanbocuoi", TypeName = "date")]
        public DateTime? Ngayphanbocuoi { get; set; }
        [Column("idvl")]
        public int? Idvl { get; set; }
        [Column("tenccdc")]
        [StringLength(350)]
        public string Tenccdc { get; set; }
        [Column("idkho")]
        public int? Idkho { get; set; }
        [Column("idphieunhap")]
        public int? Idphieunhap { get; set; }
        [Column("sophieunhap")]
        [StringLength(50)]
        public string Sophieunhap { get; set; }
        [Column("nvsd")]
        public int? Nvsd { get; set; }
        [Column("nvsd_ten")]
        [StringLength(50)]
        public string NvsdTen { get; set; }
        [Column("nguoilap")]
        public int? Nguoilap { get; set; }
        [Column("nguyengia")]
        public int? Nguyengia { get; set; }
        [Column("maccdc")]
        [StringLength(50)]
        public string Maccdc { get; set; }
        [Column("lock")]
        public bool? Lock { get; set; }
        [Column("sothangphanbo")]
        public int? Sothangphanbo { get; set; }
        [Column("tongphanbo")]
        public int? Tongphanbo { get; set; }
        [Column("conlai")]
        public int? Conlai { get; set; }
        [Column("consudung")]
        public bool? Consudung { get; set; }
        [Column("kydaphanbo")]
        public int? Kydaphanbo { get; set; }
        [Column("tkpb")]
        [StringLength(10)]
        public string Tkpb { get; set; }
    }
}
