namespace WebApplication4.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tTheDocGia")]
    public partial class tTheDocGia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tTheDocGia()
        {
            tMuonTras = new HashSet<tMuonTra>();
        }

        [Key]
        [StringLength(25)]
        public string MaThe { get; set; }

        [StringLength(25)]
        public string MaDG { get; set; }

        public DateTime? NgayBatDau { get; set; }

        public DateTime? NgayKhoaThe { get; set; }

        public virtual tDocGia tDocGia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tMuonTra> tMuonTras { get; set; }
    }
}
