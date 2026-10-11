using CourseManagementSystem.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace CourseManagementSystem.Domain.Models
{
    /// Represents a single piece of course material (PDF, URL, video link).
    public class Material : BaseEntity
    {
        // Foreign key for the ApplicationUser who created/uploaded this material.
        public string CreatorUserId { get; set; }
        public ApplicationUser CreatorUser { get; set; }


        // The title of the material ("Chapter 1").
        [MaxLength(255)]
        public string Title { get; set; }
        [MaxLength(2000)]
        public string? Description { get; set; }


        // The path or URL to the file or resource.
        [MaxLength(1024)] // Assuming a URL or file path
        public string FilePath { get; set; }



        // The type of file ("PDF", "URL", "Video").
        public FileType? FileType { get; set; } // FileType is Announcement enum


        // Navigation property for all sessions that include this material (via SessionMaterial join table).
        public ICollection<SessionMaterial> Sessions { get; set; } = new List<SessionMaterial>();
    }
}
