using Kalim.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Kalim.Core.Domain.Entities
{
    public class Lecture
    {
        [Key]
        public int LectureId { set; get; }
        public string Title { set; get; } = string.Empty;
        public DateTime? StartTime { set; get; }

        public DateTime? EndTime { set; get; }

        public LectureStatus Status { set; get; } = LectureStatus.Ended;
        public DateTime CreatedAt { set; get; } = DateTime.UtcNow;


        [ForeignKey(nameof(Room))]
        public int RoomId { set; get; }
        public Room? Room { set; get; }



        public List<Question> Questions { get; set; } = new();
        public Transcript? Transcript { get; set; }
    }
}
