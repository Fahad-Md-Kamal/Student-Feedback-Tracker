using System.ComponentModel.DataAnnotations;

namespace StudentFeedbackTracker.Models
{
    public class Note
    {
        [Key]
        public int Id { get; set; }

        [StringLength(250)]
        public string Details { get; set; }

        public Student Student { get; set; }
    }
}