using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    public partial class AclPermissions
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Resource { get; set; }
        [Column("UserID")]
        public int? UserId { get; set; }

        [ForeignKey("Resource")]
        [InverseProperty("AclPermissions")]
        public virtual AclResorces ResourceNavigation { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("AclPermissions")]
        public virtual Nhanvienit User { get; set; }
    }
}
