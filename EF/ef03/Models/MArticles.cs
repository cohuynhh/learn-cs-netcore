using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("m_articles")]
    public partial class MArticles
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("title")]
        [StringLength(500)]
        public string Title { get; set; }
        [Column("nd", TypeName = "ntext")]
        public string Nd { get; set; }
        [Column("ngay", TypeName = "date")]
        public DateTime? Ngay { get; set; }
        [Column("idcate")]
        public int? Idcate { get; set; }
    }
}
