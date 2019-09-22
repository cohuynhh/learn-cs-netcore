using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("m_chatid")]
    public partial class MChatid
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("user1")]
        public int? User1 { get; set; }
        [Column("user2")]
        public int? User2 { get; set; }
    }
}
