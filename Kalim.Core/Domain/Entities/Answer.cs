using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Kalim.Core.Domain.Entities
{
    public class Answer
    {
        [Key]
        public int AnswerId { set; get; }
        public string? AnswerText { set; get; }

        public string? AvatarVideoURL { set; get; }

        public string? RecordURL { set; get; }

        public DateTime CreatedAt { set; get; } = DateTime.UtcNow;


        [ForeignKey(nameof(Question))]
        public int QuestionId { set; get; }
        public Question? Question { set; get; }


        [ForeignKey(nameof(Instructor))]
        public int InstructorId { set; get; }
        public ApplicationUser? Instructor { set; get; }

    }
}
