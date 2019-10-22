using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudnetFeedbackTracker.Models
{
    class PersonalNote
    {
        public int Id { get; set; }
        public List<string> Note { get; set; }

        public virtual Assessment Assessment { get; set; }
        public virtual StudentUser Student { get; set; }
    }
}
