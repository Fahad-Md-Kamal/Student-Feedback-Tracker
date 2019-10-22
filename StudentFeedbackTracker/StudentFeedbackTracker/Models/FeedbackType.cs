using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudnetFeedbackTracker.Models
{
    public class FeedbackType
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        public string Type { get; set; }


        void AddType() { }
        void UpdateType() { }
        void DeleteType() { }
        // Summetive, 
        // Recommandation, 
        // Comments
    }
}
