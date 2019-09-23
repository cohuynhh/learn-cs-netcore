using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("tuvantinhgia")]
    public partial class Tuvantinhgia
    {
        [Column("gia")]
        public long? Gia { get; set; }
        [Column("ngaylienhe")]
        public long? Ngaylienhe { get; set; }
        [Column("ID")]
        public int Id { get; set; }
        [Column("create_date")]
        public long? CreateDate { get; set; }
        [Column("noidung", TypeName = "ntext")]
        public string Noidung { get; set; }
        [Column("ghichu", TypeName = "ntext")]
        public string Ghichu { get; set; }
        [Column("state")]
        public bool? State { get; set; }
        [Column("phanloai")]
        public int? Phanloai { get; set; }
        [Column("lienhelai")]
        public bool? Lienhelai { get; set; }
        [Column("ndphanhoi", TypeName = "ntext")]
        public string Ndphanhoi { get; set; }
        [Column("name")]
        [StringLength(500)]
        public string Name { get; set; }
        [Column("phone")]
        [StringLength(200)]
        public string Phone { get; set; }
        [Column("email")]
        [StringLength(200)]
        public string Email { get; set; }
        [Column("addr")]
        [StringLength(1000)]
        public string Addr { get; set; }
        [Column("city")]
        [StringLength(200)]
        public string City { get; set; }
    }
}
