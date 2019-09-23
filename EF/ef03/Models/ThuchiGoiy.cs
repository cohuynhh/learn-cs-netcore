using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("thuchi_goiy")]
    public partial class ThuchiGoiy
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("so")]
        public int? So { get; set; }
        [Column("goiy")]
        [StringLength(3000)]
        public string Goiy { get; set; }
        [Column("search")]
        [StringLength(3500)]
        public string Search { get; set; }
    }
}
