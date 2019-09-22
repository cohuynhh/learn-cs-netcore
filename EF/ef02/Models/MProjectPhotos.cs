using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("m_project_photos")]
    public partial class MProjectPhotos
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("ten")]
        [StringLength(500)]
        public string Ten { get; set; }
        [Column("url1")]
        [StringLength(500)]
        public string Url1 { get; set; }
        [Column("checked")]
        public bool? Checked { get; set; }
    }
}
