using System.ComponentModel.DataAnnotations;

namespace HealthCareBooking.Models
{
    public class Patient
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên bệnh nhân là bắt buộc.")]
        [StringLength(100, ErrorMessage = "Tên bệnh nhân không được vượt quá 100 ký tự.")]
        [Display(Name = "Họ và Tên")]
        public string FullName { get; set; } = default!; // Đã sửa lỗi: Thêm = default!;

        [Required(ErrorMessage = "Ngày sinh là bắt buộc.")]
        [DataType(DataType.Date)]
        [Display(Name = "Ngày sinh")]
        public DateTime DateOfBirth { get; set; }

        [StringLength(15, ErrorMessage = "Số điện thoại không được vượt quá 15 ký tự.")]
        [Display(Name = "Số điện thoại")]
        [Phone(ErrorMessage = "Số điện thoại không hợp lệ.")]
        public string? PhoneNumber { get; set; }

        [StringLength(255, ErrorMessage = "Địa chỉ không được vượt quá 255 ký tự.")]
        [Display(Name = "Địa chỉ")]
        public string? Address { get; set; }
    }
}