using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("cskh_processcskh")]
    public partial class CskhProcesscskh
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("datecreate", TypeName = "datetime")]
        public DateTime? Datecreate { get; set; }
        [Column("idkhach")]
        public int? Idkhach { get; set; }
        [Column("usercreate")]
        public int? Usercreate { get; set; }
        [Column("quantam")]
        public int? Quantam { get; set; }
        [Column("iskinhdoanh")]
        public bool? Iskinhdoanh { get; set; }
        [Column("ghichu")]
        [StringLength(3000)]
        public string Ghichu { get; set; }
        [Column("lock")]
        public bool? Lock { get; set; }
    }
}
