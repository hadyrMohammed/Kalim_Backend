using Kalim.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Kalim.Core.Domain.Entities
{
    public class Question
    {
        [Key]
        public int QuestionId { set; get; }
        public string? QuestionText { set; get; }
        public string? SignVideoURL { set; get; }
        public QuestionStatus Status { set; get; } = QuestionStatus.Pending;
        public DateTime CreatedAt { set; get; } = DateTime.UtcNow;


        [ForeignKey(nameof(Student))]
        public int StudentId { set; get; }
        public ApplicationUser? Student { set; get; }


        [ForeignKey(nameof(Lecture))]
        public int LectureId { set; get; }
        public Lecture? Lecture { set; get; }


        public List<Answer> Answers { get; set; } = new();
    }
}
