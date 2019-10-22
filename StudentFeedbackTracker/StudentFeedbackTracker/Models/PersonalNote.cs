using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudnetFeedbackTracker.Models
{
    public class PersonalNote
    {
        [Key]
        public int Id { get; set; }
        [StringLength(300)]
        public string Note { get; set; }

        public virtual Assessment Assessment { get; set; }
        public virtual User Student { get; set; }
    }
}
