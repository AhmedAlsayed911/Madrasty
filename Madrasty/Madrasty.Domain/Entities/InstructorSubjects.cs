using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Madrasty.Domain.Entities
{
    public class InstructorSubjects
    {
        [Key]
        public int InsId { get; set; }
        [Key]
        public int SubId { get; set; }
        [ForeignKey(nameof(InsId))]
        [InverseProperty("Ins_Subjects")]
        public virtual Instructor? instructor { get; set; }
        [ForeignKey(nameof(SubId))]
        [InverseProperty("Ins_Subjects")]
        public virtual Subject? Subject { get; set; }

    }
}
