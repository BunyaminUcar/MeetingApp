
using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "İsim bilgisi gereklidir!")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Lütfen telefon numaranızı giriniz!")]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "Email bilgisi gereklidir!")]
        public string? Email { get; set; }
        public bool? WillAttend { get; set; }
    }
}
