//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentFeedbackTracker
{
    using System;
    using System.Collections.Generic;
    
    public partial class Feedback
    {
        public int Id { get; set; }
        public string Details { get; set; }
        public Nullable<System.DateTime> FeedbackDate { get; set; }
        public int AssessementId { get; set; }
        public int FeedbackTypeId { get; set; }
    
        public virtual Assessment Assessment { get; set; }
        public virtual FeedbackType FeedbackType { get; set; }
    }
}
