using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    public partial class NhomPhu
    {
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(255)]
        public string TenNhom { get; set; }
        public int? NhomCha { get; set; }
        public int? Nhom { get; set; }
    }
}
