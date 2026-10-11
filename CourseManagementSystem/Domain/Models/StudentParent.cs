using CourseManagementSystem.Domain.Enums;

namespace CourseManagementSystem.Domain.Models
{
    // Join table linking a Student to a Parent.
    // This allows for many-to-many relationships (multiple parents per student, multiple students per parent).
    public class StudentParent : BaseEntity
    {
        public int ParentId { get; set; }
        public virtual Parent Parent { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }

        /// The type of relationship (e.g., "Mother", "Father", "Guardian").
        public RelationshipType RelationshipType { get; set; } // RelationshipType is an enum
    }

}
