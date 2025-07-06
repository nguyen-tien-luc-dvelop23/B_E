using System.ComponentModel.DataAnnotations;

namespace HealthCareBooking.Models
{
    public class Doctor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên bác sĩ là bắt buộc.")]
        [StringLength(100, ErrorMessage = "Tên bác sĩ không được vượt quá 100 ký tự.")]
        [Display(Name = "Họ và Tên")]
        public string FullName { get; set; } = default!; // Đã sửa lỗi: Thêm = default!;

        [Required(ErrorMessage = "Chuyên khoa là bắt buộc.")]
        [StringLength(100, ErrorMessage = "Chuyên khoa không được vượt quá 100 ký tự.")]
        [Display(Name = "Chuyên khoa")]
        public string Specialty { get; set; } = default!; // Đã sửa lỗi: Thêm = default!;
    }
}