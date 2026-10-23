using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Kalim.Core.Domain.Entities
{
    public class Room
    {
        [Key]
        public int RoomId { set; get; }
        public string RoomName { set; get; } = string.Empty;
        public string RoomCode { set; get; } = string.Empty;

        public DateTime CreatedAt { set; get; } = DateTime.UtcNow;

        [ForeignKey("Instructor")]
        public int InstructorId { set; get; }
        public ApplicationUser? Instructor { set; get; }



        public List<RoomMember> Members { get; set; } = new();
        public List<Lecture> Lectures { get; set; } = new();
        public List<Announcement> Announcements { get; set; } = new();
    }
}
