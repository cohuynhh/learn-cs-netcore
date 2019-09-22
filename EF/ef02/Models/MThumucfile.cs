using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("m_thumucfile")]
    public partial class MThumucfile
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("idparent")]
        public int? Idparent { get; set; }
        [Column("numchild")]
        public int? Numchild { get; set; }
        [Column("ten")]
        [StringLength(250)]
        public string Ten { get; set; }
    }
}
