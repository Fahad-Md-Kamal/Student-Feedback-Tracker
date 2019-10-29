using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentFeedbackTracker_00171328
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string fName { get; set; }
        public string Address { get; set; }
        public DateTime? DOB { get; set; }
        public string Email { get; set; }
        public int? cId { get; set; }
        public int? uId { get; set; }
    }
}
