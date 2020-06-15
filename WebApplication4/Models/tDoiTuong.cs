namespace WebApplication4.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tDoiTuong")]
    public partial class tDoiTuong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tDoiTuong()
        {
            tDocGias = new HashSet<tDocGia>();
        }

        [Key]
        [StringLength(25)]
        public string MaDT { get; set; }

        [StringLength(150)]
        public string TenDoiTuong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tDocGia> tDocGias { get; set; }
    }
}
