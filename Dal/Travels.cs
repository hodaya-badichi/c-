//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dal
{
    using System;
    using System.Collections.Generic;
    
    public partial class Travels
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Travels()
        {
            this.Requests = new HashSet<Requests>();
        }
    
        public int TravleCode { get; set; }
        public string UserId { get; set; }
        public System.DateTime Date { get; set; }
        public string SourceAddress { get; set; }
        public string DestinationAddress { get; set; }
        public int NumOfPassengers { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Requests> Requests { get; set; }
        public virtual Users Users { get; set; }
    }
}
