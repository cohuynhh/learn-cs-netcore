using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("in_phieuchi")]
    public partial class InPhieuchi
    {
        [Column("quyenso", TypeName = "ntext")]
        public string Quyenso { get; set; }
        [Column("ngaylap", TypeName = "ntext")]
        public string Ngaylap { get; set; }
        [Column("co", TypeName = "ntext")]
        public string Co { get; set; }
        [Column("no", TypeName = "ntext")]
        public string No { get; set; }
        [Column("so", TypeName = "ntext")]
        public string So { get; set; }
        [Column("nguoinhan", TypeName = "ntext")]
        public string Nguoinhan { get; set; }
        [Column("lydo", TypeName = "ntext")]
        public string Lydo { get; set; }
        [Column("sotien", TypeName = "ntext")]
        public string Sotien { get; set; }
        [Column("sotienchu", TypeName = "ntext")]
        public string Sotienchu { get; set; }
        [Column("kemtheo", TypeName = "ntext")]
        public string Kemtheo { get; set; }
        [Column("ngaychi", TypeName = "ntext")]
        public string Ngaychi { get; set; }
        [Column("nguoilap", TypeName = "ntext")]
        public string Nguoilap { get; set; }
        [Column("diachi", TypeName = "ntext")]
        public string Diachi { get; set; }
        [Column("kieuphieu", TypeName = "ntext")]
        public string Kieuphieu { get; set; }
        [Column("ID")]
        public int Id { get; set; }
    }
}
