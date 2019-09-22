using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("tinhtrangnhanvien")]
    public partial class Tinhtrangnhanvien
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("loai", TypeName = "ntext")]
        public string Loai { get; set; }
    }
}
