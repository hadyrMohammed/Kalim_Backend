using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Kalim.Core.Domain.Entities
{
    public class Announcement
    {
        [Key]
        public int AnnouncementId { set; get; }
        public string Title { set; get; } = string.Empty;
        public string Content { set; get; } = string.Empty;
        public string? AttachmentURL { set; get; }
        public DateTime CreatedAt { set; get; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { set; get; }


        [ForeignKey(nameof(Room))]
        public int RoomId { set; get; }
        public Room? Room { set; get; }


        [ForeignKey(nameof(Instructor))]
        public int InstructorId { set; get; }
        public ApplicationUser? Instructor { set; get; }
    }
}
