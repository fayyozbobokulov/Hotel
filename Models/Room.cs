using Hotel.Config.Enums;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public RoomStatus Status { get; set; }
        
    }
}
