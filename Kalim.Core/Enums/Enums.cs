using System;
using System.Collections.Generic;
using System.Text;

namespace Kalim.Core.Enums
{
    public enum CodeStatus
    {
        Active = 1, Cancelled = 2, Expired = 3, Exhausted = 4
    }

    public enum TokenStatus {
        Active = 1, Used = 2, Expired = 3
    }

    public enum LectureStatus
    { 
        Live = 1, Ended = 2 
    }

    public enum QuestionStatus {
        Pending = 1, Answered = 2 
    }

    public enum TranscriptStatus 
    { 
        NotRequested = 0, Processing = 1, Ready = 2, Failed = 3 
    }

    public enum NotificationType
    {
        NewQuestion = 1, AnswerReady = 2, NewAnnouncement = 3, AvatarReady = 4
    }

    public enum UserStatus
    {
        Active = 1 , Deactivated = 2
    }
}
