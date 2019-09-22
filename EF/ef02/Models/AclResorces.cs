using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    public partial class AclResorces
    {
        public AclResorces()
        {
            AclPermissions = new HashSet<AclPermissions>();
        }

        [Key]
        [StringLength(255)]
        public string Resource { get; set; }
        [Column("RGroup")]
        [StringLength(255)]
        public string Rgroup { get; set; }
        [StringLength(255)]
        public string Description { get; set; }

        [InverseProperty("ResourceNavigation")]
        public virtual ICollection<AclPermissions> AclPermissions { get; set; }
    }
}
