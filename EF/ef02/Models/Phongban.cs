using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("phongban")]
    public partial class Phongban
    {
        [Column("ID")]
        public int Id { get; set; }
        public int? Truong { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
    }
}
