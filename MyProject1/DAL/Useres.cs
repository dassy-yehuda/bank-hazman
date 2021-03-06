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
    
    public partial class Useres
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Useres()
        {
            this.Lessons = new HashSet<Lessons>();
            this.Lessons1 = new HashSet<Lessons>();
            this.LimitToTeacher = new HashSet<LimitToTeacher>();
            this.Request = new HashSet<Request>();
            this.TimeToUser = new HashSet<TimeToUser>();
            this.Waiting = new HashSet<Waiting>();
        }
    
        public int CodeUser { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Password { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public int CodeStreet { get; set; }
        public Nullable<int> CodeSector { get; set; }
        public Nullable<int> Min { get; set; }
        public Nullable<int> AgeMin { get; set; }
        public Nullable<int> AgeMax { get; set; }
        public Nullable<double> AddressX { get; set; }
        public Nullable<double> AddressY { get; set; }
        public Nullable<int> MinToLearn { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lessons> Lessons { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lessons> Lessons1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LimitToTeacher> LimitToTeacher { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Request> Request { get; set; }
        public virtual Sector Sector { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TimeToUser> TimeToUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Waiting> Waiting { get; set; }
    }
}
