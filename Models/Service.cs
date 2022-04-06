using Hotel.Config.Enums;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public ServiceStatus Status { get; set; }
        public string Description { get; set; }
    }
}
