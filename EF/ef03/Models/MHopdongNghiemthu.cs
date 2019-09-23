using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("m_hopdong_nghiemthu")]
    public partial class MHopdongNghiemthu
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("sotien")]
        public int? Sotien { get; set; }
        [Column("diengiai")]
        [StringLength(500)]
        public string Diengiai { get; set; }
        [Column("file_id")]
        public int? FileId { get; set; }
        [Column("hopdong_id")]
        public int? HopdongId { get; set; }
        [Column("active")]
        public bool? Active { get; set; }
        [Column("kieu")]
        public int? Kieu { get; set; }
        [Column("ngay", TypeName = "date")]
        public DateTime? Ngay { get; set; }
    }
}
