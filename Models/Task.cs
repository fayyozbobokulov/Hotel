using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime? CreatedDate { get; set; }

        public DateTime? SubmissionTime { get; set; }
        [DataType(DataType.Date)]
        public DateTime UpdatedAt { get; set; }
        [Required]
        public string Description { get; set; }

    }
}
