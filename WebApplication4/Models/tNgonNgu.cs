namespace WebApplication4.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tNgonNgu")]
    public partial class tNgonNgu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tNgonNgu()
        {
            tSaches = new HashSet<tSach>();
        }

        [Key]
        [StringLength(25)]
        public string MaNgonNgu { get; set; }

        [StringLength(100)]
        public string TenNgonNgu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tSach> tSaches { get; set; }
    }
}
