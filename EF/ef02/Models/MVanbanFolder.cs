using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("m_vanban_folder")]
    public partial class MVanbanFolder
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("ten")]
        [StringLength(200)]
        public string Ten { get; set; }
    }
}
