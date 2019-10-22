using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudnetFeedbackTracker.Models
{
    public class CouseSubject
    {
        public int CId { get; set; }
        public Course Course { get; set; }

        public int SubId { get; set; }
        public Subject Subject { get; set; }

    }
}
