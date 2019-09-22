using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Models
{
    [Table("contract_states")]
    public partial class ContractStates
    {
        public ContractStates()
        {
            MHopdong = new HashSet<MHopdong>();
        }

        [Column("ID")]
        public int Id { get; set; }
        [Column("code")]
        public int Code { get; set; }
        [Required]
        [Column("label")]
        [StringLength(50)]
        public string Label { get; set; }

        public virtual ICollection<MHopdong> MHopdong { get; set; }
    }
}
