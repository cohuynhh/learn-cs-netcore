using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("cskh_khachhang")]
    public partial class CskhKhachhang
    {
        [Column("name")]
        [StringLength(100)]
        public string Name { get; set; }
        [Column("gender")]
        public bool? Gender { get; set; }
        [Column("dateofbirth", TypeName = "date")]
        public DateTime? Dateofbirth { get; set; }
        [Column("province")]
        [StringLength(50)]
        public string Province { get; set; }
        [Column("addr")]
        [StringLength(300)]
        public string Addr { get; set; }
        [Column("phone")]
        [StringLength(100)]
        public string Phone { get; set; }
        [Column("email")]
        [StringLength(150)]
        public string Email { get; set; }
        [Column("soure")]
        [StringLength(150)]
        public string Soure { get; set; }
        [Column("consultants")]
        public int? Consultants { get; set; }
        [Column("purpose")]
        [StringLength(500)]
        public string Purpose { get; set; }
        [Column("datecreate", TypeName = "date")]
        public DateTime? Datecreate { get; set; }
        [Column("usercreate")]
        public int? Usercreate { get; set; }
        [Column("lock")]
        public bool? Lock { get; set; }
        [Column("ID")]
        public int Id { get; set; }
        [Column("mucquantam")]
        public int? Mucquantam { get; set; }
        [Column("notefull")]
        [StringLength(4000)]
        public string Notefull { get; set; }
        [Column("search")]
        [StringLength(2000)]
        public string Search { get; set; }
        [Column("logs", TypeName = "ntext")]
        public string Logs { get; set; }
        [Column("idlink")]
        public int? Idlink { get; set; }
        [Column("lastupdate", TypeName = "datetime")]
        public DateTime? Lastupdate { get; set; }
        [Column("mucquantam_cskh")]
        public int? MucquantamCskh { get; set; }
        [Column("count_mucquantam")]
        public int? CountMucquantam { get; set; }
        [Column("count_mucquantam_cskh")]
        public int? CountMucquantamCskh { get; set; }
        [Column("mgs_kinhdoanh")]
        [StringLength(150)]
        public string MgsKinhdoanh { get; set; }
        [Column("mgs_cskh")]
        [StringLength(150)]
        public string MgsCskh { get; set; }
        [Column("mgs_mgs")]
        [StringLength(150)]
        public string MgsMgs { get; set; }
        [Column("active")]
        public bool? Active { get; set; }
    }
}
