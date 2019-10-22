using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudnetFeedbackTracker.Models
{
    public class BatchStudent
    {
        public int SId { get; set; }
        public UserBase Student { get; set; }

        public int BId { get; set; }
        public Batch Batch { get; set; }
    }
}
