using Microsoft.AspNetCore.Identity;
using Kalim.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Kalim.Core.Domain.Entities
{
    public class ApplicationUser:IdentityUser<int>
    {
        public string Name { set; get; } = string.Empty;
        public UserStatus Status { set; get; } = UserStatus.Active;
        public DateTime CreatedAt { set; get; } = DateTime.UtcNow;



        public List<Room> CreatedRooms { get; set; } = new();

        public List<RoomMember> Members { get; set; } = new();

        public List<Question> Questions { get; set; } = new();

        public List<Answer> Answers { get; set; } = new();

        public List<Announcement> Announcements { get; set; } = new();

        public List<Notification> Notifications { get; set; } = new();

        public List<PasswordResetToken> PasswordResetTokens { get; set; } = new();

        public List<ActivationCode> CreatedActivationCodes { get; set; } = new();
    }
}
