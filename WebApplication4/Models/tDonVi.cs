namespace WebApplication4.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tDonVi")]
    public partial class tDonVi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tDonVi()
        {
            tDocGias = new HashSet<tDocGia>();
        }

        [Key]
        [StringLength(25)]
        public string MaDonVi { get; set; }

        [StringLength(150)]
        public string TenDonVi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tDocGia> tDocGias { get; set; }
    }
}
