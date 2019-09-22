using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("m_filedata")]
    public partial class MFiledata
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("datafile", TypeName = "image")]
        public byte[] Datafile { get; set; }
        [Column("lock")]
        public bool? Lock { get; set; }
        [Column("numberdownload")]
        public int? Numberdownload { get; set; }
        [Column("nhanvien")]
        public int? Nhanvien { get; set; }
        [Column("hopdong")]
        public int? Hopdong { get; set; }
        [Column("documenttype")]
        public int? Documenttype { get; set; }
        [Column("anhnho", TypeName = "image")]
        public byte[] Anhnho { get; set; }
        [Column("ngay", TypeName = "datetime")]
        public DateTime? Ngay { get; set; }
        [Column("groupfile")]
        public int? Groupfile { get; set; }
        [Column("lastcomment")]
        [StringLength(500)]
        public string Lastcomment { get; set; }
        [Column("idvatlieu")]
        [StringLength(200)]
        public string Idvatlieu { get; set; }
        [Column("isimg")]
        public bool? Isimg { get; set; }
        [Column("url1")]
        [StringLength(400)]
        public string Url1 { get; set; }
        [Column("idroom")]
        public int? Idroom { get; set; }
        [Column("idstyle")]
        public int? Idstyle { get; set; }
        [Column("desp", TypeName = "ntext")]
        public string Desp { get; set; }
        [Column("idproject")]
        public int? Idproject { get; set; }
        [Column("urlsmall")]
        [StringLength(400)]
        public string Urlsmall { get; set; }
        [Column("idurl")]
        public int? Idurl { get; set; }
        [Column("searchtext")]
        [StringLength(450)]
        public string Searchtext { get; set; }
        [Column("idmail")]
        public int? Idmail { get; set; }
        [Column("idxdkt")]
        public int? Idxdkt { get; set; }
        [Column("idsubfolder")]
        public int? Idsubfolder { get; set; }
        [StringLength(500)]
        public string Name { get; set; }
        [Column("path")]
        [StringLength(500)]
        public string Path { get; set; }
        [Column("sizefile")]
        [StringLength(15)]
        public string Sizefile { get; set; }
        [Column("uploader")]
        [StringLength(50)]
        public string Uploader { get; set; }
        [Column("lastupdate", TypeName = "datetime")]
        public DateTime? Lastupdate { get; set; }
        [Column("soluongcoment")]
        public int? Soluongcoment { get; set; }
        [Column("allcoment")]
        [StringLength(3000)]
        public string Allcoment { get; set; }
        [Column("filetype")]
        [StringLength(15)]
        public string Filetype { get; set; }
        [Column("tenkhach")]
        [StringLength(200)]
        public string Tenkhach { get; set; }
        [Column("objectid")]
        public int? Objectid { get; set; }
        [Column("size")]
        public double? Size { get; set; }

        [ForeignKey("Nhanvien")]
        [InverseProperty("MFiledata")]
        public virtual Nhanvienit NhanvienNavigation { get; set; }
    }
}
