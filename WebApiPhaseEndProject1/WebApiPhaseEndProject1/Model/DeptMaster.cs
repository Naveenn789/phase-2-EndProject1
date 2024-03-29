﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiPhaseEndProject1.Model
{
    [Table("DeptMaster")]
    public class DeptMaster
    {
        [Key]
        public int? DeptCode { get; set; }
        public string? DeptName { get; set; }
        public virtual ICollection<EmpProfile>? EmpProfiles { get; set; }
    }
    
}
