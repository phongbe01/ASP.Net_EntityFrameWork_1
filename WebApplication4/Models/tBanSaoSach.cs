namespace WebApplication4.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tBanSaoSach")]
    public partial class tBanSaoSach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tBanSaoSach()
        {
            tMuonTras = new HashSet<tMuonTra>();
        }

        [Key]
        [StringLength(25)]
        public string MaBanSao { get; set; }

        [StringLength(25)]
        public string MaSach { get; set; }

        public bool? TrangThai { get; set; }

        [StringLength(255)]
        public string TinhTrangSach { get; set; }

        [StringLength(255)]
        public string ViTri { get; set; }

        public virtual tSach tSach { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tMuonTra> tMuonTras { get; set; }
    }
}
