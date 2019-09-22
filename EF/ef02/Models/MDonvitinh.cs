using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("m_donvitinh")]
    public partial class MDonvitinh
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("tendv")]
        [StringLength(50)]
        public string Tendv { get; set; }
    }
}
