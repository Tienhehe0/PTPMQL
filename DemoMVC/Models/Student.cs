using System;
using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class Student
    {
        public string StudentID { get; set; }     // STD001, STD002, ...

        [Required(ErrorMessage = "Họ và tên bắt buộc.")]
        [StringLength(100, ErrorMessage = "Tên không vượt quá 100 ký tự.")]
        public string FullName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Ngày sinh")]
        public DateTime DateOfBirth { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [EmailAddress(ErrorMessage = "Email không hợp lệ.")]
        public string Email { get; set; }
    }
}
