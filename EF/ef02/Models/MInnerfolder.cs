using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("m_innerfolder")]
    public partial class MInnerfolder
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("namef")]
        [StringLength(200)]
        public string Namef { get; set; }
        [Column("idhopdong")]
        public int? Idhopdong { get; set; }
    }
}
