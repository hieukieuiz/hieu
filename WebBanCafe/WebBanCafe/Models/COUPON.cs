//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBanCafe.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class COUPON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COUPON()
        {
            this.BILLs = new HashSet<BILL>();
        }
    
        public string COUPON_ID { get; set; }
        public Nullable<int> VALUE { get; set; }
        public Nullable<System.DateTime> EXPIRYDATE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BILL> BILLs { get; set; }
    }
}
