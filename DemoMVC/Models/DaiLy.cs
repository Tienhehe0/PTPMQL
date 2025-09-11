using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class DaiLy 
    {
        public int Id { get; set; }
        public string MaDaiLy { get; set; }= string.Empty;
        public string TenDaiLy { get; set; }= string.Empty;
        public string DiaChi { get; set; }= string.Empty;
        public string NguoiDaiDien { get; set; }= string.Empty;
        public string DienThoai { get; set; }= string.Empty;
    }
}