using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("m_email")]
    public partial class MEmail
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("frommail")]
        [StringLength(50)]
        public string Frommail { get; set; }
        [Column("mail")]
        [StringLength(50)]
        public string Mail { get; set; }
        [Column("body", TypeName = "ntext")]
        public string Body { get; set; }
        [Column("ngay", TypeName = "datetime")]
        public DateTime? Ngay { get; set; }
        [Column("chude")]
        [StringLength(500)]
        public string Chude { get; set; }
        [Column("ten")]
        [StringLength(100)]
        public string Ten { get; set; }
        [Column("tomail")]
        [StringLength(50)]
        public string Tomail { get; set; }
        [Column("issend")]
        public bool? Issend { get; set; }
    }
}
