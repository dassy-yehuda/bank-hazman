//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lessons
    {
        public int CodeLesson { get; set; }
        public Nullable<int> CodeLimit { get; set; }
        public int CodeTeacher { get; set; }
        public Nullable<int> CodeStudent { get; set; }
        public Nullable<System.DateTime> DateLesson { get; set; }
    
        public virtual Limit Limit { get; set; }
        public virtual Useres Useres { get; set; }
        public virtual Useres Useres1 { get; set; }
    }
}
