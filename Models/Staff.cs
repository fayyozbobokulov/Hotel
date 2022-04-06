using Hotel.Config.Enums;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    public class Staff
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public UserType Type { get; set; }
        public string Position { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
