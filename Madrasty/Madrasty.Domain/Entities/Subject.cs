using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Madrasty.Domain.Entities
{
    public class Subject
    {
        public Subject()
        {
            StudentsSubjects = new HashSet<StudentSubject>();
            DepartmentsSubjects = new HashSet<DepartmentSubject>();
        }

        [Key]
        public int SubID { get; set; }
        [StringLength(200)]
        public string SubjectName { get; set; }
        public DateTime Period { get; set;  }
        public virtual ICollection<StudentSubject> StudentsSubjects { get; set; }
        public virtual ICollection<DepartmentSubject> DepartmentsSubjects { get; set; }
    }
}
