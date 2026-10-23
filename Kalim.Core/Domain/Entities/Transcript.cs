using Kalim.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Kalim.Core.Domain.Entities
{
    public class Transcript
    {
        [Key]
        public int TranscriptId { set; get; }

        public string TranscriptText { set; get; } = string.Empty;

        public string? AvatarVideoURL { set; get; }
        public TranscriptStatus Status { set; get; } = TranscriptStatus.NotRequested;
        public DateTime CreatedAt { set; get; } = DateTime.UtcNow;


        [ForeignKey(nameof(Lecture))]
        public int LectureId { set; get; }
        public Lecture? Lecture { set; get; }
    }
}
