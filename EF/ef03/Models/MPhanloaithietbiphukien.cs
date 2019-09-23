using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("m_phanloaithietbiphukien")]
    public partial class MPhanloaithietbiphukien
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("loai")]
        [StringLength(100)]
        public string Loai { get; set; }
    }
}
