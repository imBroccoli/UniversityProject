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
    
    public partial class tblTeacher
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblTeacher()
        {
            this.tblSubjectTeachers = new HashSet<tblSubjectTeacher>();
        }
    
        public int Id { get; set; }
        public Nullable<int> StaffId { get; set; }
    
        public virtual tblStaff tblStaff { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSubjectTeacher> tblSubjectTeachers { get; set; }
    }
}
