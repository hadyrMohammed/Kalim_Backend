using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Kalim.Core.Domain.Entities
{
    public class RoomMember
    {
       

        [ForeignKey(nameof(Room))]
        public int RoomId { set; get; }
        public Room? Room { set; get; }


        [ForeignKey(nameof(Student))]
        public int StudentId { set; get; }
        public ApplicationUser? Student { set; get; }
    }
}
