using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudnetFeedbackTracker.Models
{
    public class FeedbackType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        

        void AddType() { }
        void UpdateType() { }
        void DeleteType() { }
        // Summetive, 
        // Recommandation, 
        // Comments
    }
}
