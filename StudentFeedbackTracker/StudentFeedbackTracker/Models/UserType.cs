using System.ComponentModel.DataAnnotations;

namespace StudnetFeedbackTracker.Models
{
    public class UserType
    {
        [Key]
        public int Id { get; set; }
        [StringLength(250)]
        public string Type { get; set; }

        void AddType() { }
        void UpdateType() { }
        void DeleteType() { }
    }
}