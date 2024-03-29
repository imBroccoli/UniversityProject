//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentFeedbackTrackingSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblFeedback
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblFeedback()
        {
            this.tblNotes = new HashSet<tblNote>();
            this.tblWordClouds = new HashSet<tblWordCloud>();
        }
    
        public int Id { get; set; }
        public string Keywords { get; set; }
        public string Description { get; set; }
        public Nullable<int> FeedbackTypeId { get; set; }
        public Nullable<int> AssessmentId { get; set; }
    
        public virtual tblAssessment tblAssessment { get; set; }
        public virtual tblFeedbackType tblFeedbackType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblNote> tblNotes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblWordCloud> tblWordClouds { get; set; }
    }
}
