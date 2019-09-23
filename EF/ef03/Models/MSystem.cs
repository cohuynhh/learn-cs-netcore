using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("m_system")]
    public partial class MSystem
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("lastupdateonline", TypeName = "datetime")]
        public DateTime? Lastupdateonline { get; set; }
    }
}
