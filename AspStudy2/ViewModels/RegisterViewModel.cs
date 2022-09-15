using System.ComponentModel.DataAnnotations;

namespace AspStudy2.ViewModels
{
    #pragma warning disable CS8618 // Nullable
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "필수 정보입니다.")]
        [Display(Name = "아이디")]
        public string UserId { get; set; }

        [Required(ErrorMessage = "필수 정보입니다.")]
        [StringLength(16, ErrorMessage = "{0}은(는) 최소 {2}, 최대 {1} 글자여야 합니다.", MinimumLength = 8)]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = "비밀번호 형식이 올바르지 않습니다. (영문, 숫자, 특수문자를 최소 한가지씩 조합)")]
        [Display(Name = "비밀번호")]
        public string Password { get; set; }

        [Required(ErrorMessage = "필수 정보입니다.")]
        [DataType(DataType.Password)]
        [Display(Name = "비밀번호 확인")]
        [Compare("Password", ErrorMessage = "입력하신 비밀번호와 일치하지 않습니다.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "필수 정보입니다.")]
        [Display(Name = "이름")]
        public string Name { get; set; }

        [Required(ErrorMessage = "필수 정보입니다.")]
        [RegularExpression(@"^[0-9a-zA-Z]([-_.]?[0-9a-zA-Z])*@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "이메일 형식이 올바르지 않습니다.")]
        [Display(Name = "이메일(본인 확인용)")]
        public string Email { get; set; }
    }
}