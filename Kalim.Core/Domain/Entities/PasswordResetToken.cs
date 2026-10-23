using Kalim.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Kalim.Core.Domain.Entities
{
    public class PasswordResetToken
    {
        [Key]
        public int PasswordResetTokenId { set; get; }

        public string TokenHash { set; get; } = string.Empty;

        public DateTime ExpirationDate { set; get; }

        public TokenStatus TokenStatus { set; get; } = TokenStatus.Active;

        [ForeignKey(nameof(User))]
        public int UserId { set; get; }

        public ApplicationUser? User { set; get; }
    }
}
