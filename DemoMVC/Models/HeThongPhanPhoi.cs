using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
{
    [Table("HeThongPhanPhoi")]
    public class HeThongPhanPhoi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HTPPId { get; set; }

        public string MaHTPP { get; set; } 

        [Required]
        public string TenHTPP { get; set; }

        public string DiaChi { get; set; }

        public string NguoiDaiDien { get; set; }

        public string DienThoai { get; set; }
    }
}