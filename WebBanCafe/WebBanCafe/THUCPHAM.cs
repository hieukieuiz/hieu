namespace WebBanCafe
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THUCPHAM")]
    public partial class THUCPHAM
    {
        [Key]
        [StringLength(30)]
        public string MASANPHAM { get; set; }

        [StringLength(50)]
        public string TENSANPHAM { get; set; }

        public int? GIA { get; set; }

        [StringLength(30)]
        public string MALOAISANPHAM { get; set; }

        public virtual LOAITHUCPHAM LOAITHUCPHAM { get; set; }
    }
}
