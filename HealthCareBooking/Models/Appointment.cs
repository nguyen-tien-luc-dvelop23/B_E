using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthCareBooking.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ngày và giờ hẹn là bắt buộc.")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Ngày giờ hẹn")]
        public DateTime AppointmentDate { get; set; }

        [Required(ErrorMessage = "Bệnh nhân là bắt buộc.")]
        [Display(Name = "Bệnh nhân")]
        public int PatientId { get; set; }

        [ForeignKey("PatientId")]
        public Patient Patient { get; set; } = default!; // Đã sửa lỗi: Thêm = default!;

        [Required(ErrorMessage = "Bác sĩ là bắt buộc.")]
        [Display(Name = "Bác sĩ")]
        public int DoctorId { get; set; }

        [ForeignKey("DoctorId")]
        public Doctor Doctor { get; set; } = default!; // Đã sửa lỗi: Thêm = default!;

        [StringLength(500, ErrorMessage = "Ghi chú không được vượt quá 500 ký tự.")]
        [Display(Name = "Ghi chú")]
        public string? Notes { get; set; }
    }
}