﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudnetFeedbackTracker.Models
{
    public class AssessmentType
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string AssessmentName { get; set; }


        void AddType() { }
        void UpdateType() { }
        void DeleteType() { }
    }
}
