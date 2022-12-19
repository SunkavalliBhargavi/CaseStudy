//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CropWebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CROP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CROP()
        {
            this.INVOICEs = new HashSet<INVOICE>();
            this.ORDERS = new HashSet<ORDER>();
        }
    
        public int ID { get; set; }
        public Nullable<int> User_ID { get; set; }
        public string Name { get; set; }
        public byte[] Crop_IMG { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string Status { get; set; }
    
        public virtual UserProfile UserProfile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVOICE> INVOICEs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDER> ORDERS { get; set; }
    }
}
