using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    public partial class NhomChinh
    {
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(255)]
        public string TenNhom { get; set; }
        [Column("STT")]
        public int? Stt { get; set; }
    }
}
