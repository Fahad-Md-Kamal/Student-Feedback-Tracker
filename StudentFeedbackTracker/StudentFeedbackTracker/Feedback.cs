//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ADIDemoDec19
{
    using System;
    using System.Collections.Generic;
    
    public partial class Feedback
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Feedback()
        {
            this.Notes = new HashSet<Note>();
            this.WordClouds = new HashSet<WordCloud>();
        }
    
        public int Id { get; set; }
        public string Keywords { get; set; }
        public string Description { get; set; }
        public Nullable<int> fbTypeId { get; set; }
        public Nullable<int> assId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Note> Notes { get; set; }
        public virtual FeedbackType FeedbackType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WordCloud> WordClouds { get; set; }
    }
}
