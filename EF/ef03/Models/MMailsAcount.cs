using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("m_mails_acount")]
    public partial class MMailsAcount
    {
        [Column("account")]
        [StringLength(50)]
        public string Account { get; set; }
        [Column("pass")]
        [StringLength(50)]
        public string Pass { get; set; }
        [Column("ID")]
        public int Id { get; set; }
    }
}
