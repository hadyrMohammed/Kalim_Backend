using Kalim.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Kalim.Core.Domain.Entities
{
    public class ActivationCode
    {
        [Key]
        public int CodeId { set; get; }

        public string Code { set; get; } = string.Empty;

        public DateTime ExpiresAt { set; get; }

        public int RemainingUses { set; get; }

        public CodeStatus Status { set; get; } = CodeStatus.Active;


        [ForeignKey(nameof(Admin))]
        public int AdminId { set; get; }
        public ApplicationUser? Admin { set; get; }
    }
}
