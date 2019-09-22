using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("m_chat")]
    public partial class MChat
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("usersend")]
        public int? Usersend { get; set; }
        [Column("datesend", TypeName = "datetime")]
        public DateTime? Datesend { get; set; }
        [Column("message")]
        [StringLength(1000)]
        public string Message { get; set; }
        [Column("haveread")]
        public bool? Haveread { get; set; }
        [Column("chatid")]
        public int? Chatid { get; set; }
        [Column("userreceive")]
        public int? Userreceive { get; set; }
        [Column("username")]
        [StringLength(200)]
        public string Username { get; set; }
        [Column("kieu")]
        public int? Kieu { get; set; }
    }
}
