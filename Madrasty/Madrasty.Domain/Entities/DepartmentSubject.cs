using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Madrasty.Domain.Entities
{
    public class DepartmentSubject
    {
        [Key]
        public int DeptSubID { get; set; }
        public int DID { get; set; }
        public int SubID { get; set; }
        [ForeignKey("DID")]
        public virtual Department Department { get; set; }

        [ForeignKey("SubID")]
        public virtual Subject Subjects { get; set; }
    }
}
