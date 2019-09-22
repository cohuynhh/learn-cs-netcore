using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("m_vanban")]
    public partial class MVanban
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("ten")]
        [StringLength(500)]
        public string Ten { get; set; }
        [Column("ngay", TypeName = "datetime")]
        public DateTime? Ngay { get; set; }
        [Column("ghichu", TypeName = "ntext")]
        public string Ghichu { get; set; }
        [Column("idfolder")]
        public int? Idfolder { get; set; }
        [Column("tenuser")]
        [StringLength(50)]
        public string Tenuser { get; set; }
        [Column("lock")]
        public bool? Lock { get; set; }
        [Column("search")]
        [StringLength(500)]
        public string Search { get; set; }
    }
}
