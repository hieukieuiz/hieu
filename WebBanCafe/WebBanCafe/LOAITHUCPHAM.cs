namespace WebBanCafe
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAITHUCPHAM")]
    public partial class LOAITHUCPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAITHUCPHAM()
        {
            THUCPHAMs = new HashSet<THUCPHAM>();
        }

        [Key]
        [StringLength(30)]
        public string MALOAISANPHAM { get; set; }

        [StringLength(50)]
        public string TENLOAISANPHAM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THUCPHAM> THUCPHAMs { get; set; }
    }
}
