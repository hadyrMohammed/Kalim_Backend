using Kalim.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Kalim.Core.Domain.Entities
{
    public class Notification
    {
        [Key]
        public int NotificationId { set; get; }
        public string Title { set; get; } = string.Empty;

        [Required]
        public string Message { set; get; } = string.Empty;

        public NotificationType Type { set; get; } 

        public bool IsRead { set; get; } = false;

        public DateTime CreatedAt { set; get; } = DateTime.UtcNow;


        [ForeignKey(nameof(User))]
        public int UserId { set; get; }
        public ApplicationUser? User { set; get; }
    }
}
