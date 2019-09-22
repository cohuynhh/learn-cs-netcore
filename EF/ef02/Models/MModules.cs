using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("m_modules")]
    public partial class MModules
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("ten", TypeName = "ntext")]
        public string Ten { get; set; }
        [Column("img")]
        public int? Img { get; set; }
    }
}
