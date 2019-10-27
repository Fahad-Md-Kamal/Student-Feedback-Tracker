﻿using System.ComponentModel.DataAnnotations;

namespace StudentFeedbackTracker.Models
{
    public class AssessmentType
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20)]
        public string AssessementType { get; set; }
    }
}