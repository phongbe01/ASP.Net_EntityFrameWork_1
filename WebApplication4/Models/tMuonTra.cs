namespace WebApplication4.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tMuonTra")]
    public partial class tMuonTra
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(25)]
        public string MaThe { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string MaBanSao { get; set; }

        public double? DatCoc { get; set; }

        public DateTime? NgayMuon { get; set; }

        public DateTime? NgayPhaiTra { get; set; }

        public DateTime? NgayTra { get; set; }

        [StringLength(155)]
        public string TinhTrangSach { get; set; }

        public double? Phat { get; set; }

        public virtual tBanSaoSach tBanSaoSach { get; set; }

        public virtual tTheDocGia tTheDocGia { get; set; }
    }
}
