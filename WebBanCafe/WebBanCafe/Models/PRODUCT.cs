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
    
    public partial class PRODUCT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUCT()
        {
            this.CARTs = new HashSet<CART>();
        }
    
        public string PRODUCT_ID { get; set; }
        public string PRODUCT_NAME { get; set; }
        public Nullable<double> PRICE { get; set; }
        public string CONTENT { get; set; }
        public string CATEGORY_ID { get; set; }
        public string IMG_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CART> CARTs { get; set; }
        public virtual CATEGORY CATEGORY { get; set; }
        public virtual IMG IMG { get; set; }
    }
}