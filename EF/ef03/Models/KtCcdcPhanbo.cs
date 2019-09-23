using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("kt_ccdc_phanbo")]
    public partial class KtCcdcPhanbo
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("ngayphanbo", TypeName = "date")]
        public DateTime? Ngayphanbo { get; set; }
        [Column("sotien")]
        public int? Sotien { get; set; }
        [Column("active")]
        public bool? Active { get; set; }
        [Column("idccdc")]
        public int? Idccdc { get; set; }
        [Column("lock")]
        public bool? Lock { get; set; }
    }
}
