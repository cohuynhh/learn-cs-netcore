using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("m_module")]
    public partial class MModule
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("ten", TypeName = "ntext")]
        public string Ten { get; set; }
        [Column("kichthuoc", TypeName = "ntext")]
        public string Kichthuoc { get; set; }
        [Column("thietbi", TypeName = "ntext")]
        public string Thietbi { get; set; }
        [Column("idmodule")]
        public int? Idmodule { get; set; }
    }
}
