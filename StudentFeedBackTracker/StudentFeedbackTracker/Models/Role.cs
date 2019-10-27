using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentFeedbackTracker.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20)]
        public string RoleName { get; set; }

        public IList<User> Users { get; set; }
    }
}
