using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudnetFeedbackTracker.Models
{
    public class Batch
    {
        public int Id { get; set; }
        public string BatchName { get; set; }

        public List<BatchStudent> Studens { get; set; }
        public List<StaffUser> Staffs { get; set; }


        public void CreateBatch() { }

        public void UpdateBatch() { }

        public void DeleteBatch() { }

        public void GetAllStudents() { }

        public void GetDetailOfAStudent() { }

        public void GetAllInstructor() { }

        public void GetDetailOfAnInstructor() { }


    }
}
