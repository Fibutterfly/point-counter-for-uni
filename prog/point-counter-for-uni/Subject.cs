//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace point_counter_for_uni
{
    using System;
    using System.Collections.Generic;
    
    public partial class Subject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Subject()
        {
            this.Max_type_points = new HashSet<Max_type_points>();
            this.StudxSubs = new HashSet<StudxSub>();
        }
    
        public int Sub_SK { get; set; }
        public string SubCode_FK { get; set; }
        public string Year { get; set; }
        public Nullable<int> elegseges { get; set; }
        public Nullable<int> kozepes { get; set; }
        public Nullable<int> jo { get; set; }
        public Nullable<int> jeles { get; set; }
        public bool alairas { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Max_type_points> Max_type_points { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudxSub> StudxSubs { get; set; }
        public virtual Subject_name Subject_name { get; set; }
    }
}
