using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Madrasty.Domain.Entities
{
    public class Instructor
    {
        public Instructor()
        {
            Instructors = new HashSet<Instructor>();
            Ins_Subjects = new HashSet<InstructorSubjects>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InsId { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Position { get; set; }
        public int? SupervisorId { get; set; }
        public decimal? Salary { get; set; }
        public string? Image { get; set; }
        public int DID { get; set; }
        [ForeignKey(nameof(DID))]
        [InverseProperty("Instructors")]
        public virtual Department? Department { get; set; }

        [InverseProperty("Instructor")]
        public virtual Department? DepartmentManager { get; set; }


        [ForeignKey(nameof(SupervisorId))]
        [InverseProperty("Instructors")]
        public virtual Instructor? Supervisor { get; set; }
        [InverseProperty("Supervisor")]
        public virtual ICollection<Instructor> Instructors { get; set; }

        [InverseProperty("instructor")]
        public virtual ICollection<InstructorSubjects> Ins_Subjects { get; set; }

    }
}
