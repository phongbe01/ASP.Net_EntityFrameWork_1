namespace WebApplication4.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tDocGia")]
    public partial class tDocGia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tDocGia()
        {
            tTheDocGias = new HashSet<tTheDocGia>();
        }

        [Key]
        [StringLength(25)]
        public string MaDG { get; set; }

        [StringLength(55)]
        public string HoDem { get; set; }

        [StringLength(25)]
        public string TenDG { get; set; }

        [StringLength(25)]
        public string SoCMND { get; set; }

        [StringLength(25)]
        public string MaDonVi { get; set; }

        public DateTime? Ngaysinh { get; set; }

        [StringLength(25)]
        public string MaDT { get; set; }

        [StringLength(200)]
        public string DiaChi { get; set; }

        [StringLength(150)]
        public string Anh { get; set; }

        public virtual tDoiTuong tDoiTuong { get; set; }

        public virtual tDonVi tDonVi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tTheDocGia> tTheDocGias { get; set; }
    }
}
