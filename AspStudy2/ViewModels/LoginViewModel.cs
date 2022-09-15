using System.ComponentModel.DataAnnotations;

namespace AspStudy2.ViewModels
{
    #pragma warning disable CS8618 // Nullable
    public class LoginViewModel
    {
        [Required(ErrorMessage = "{0}를 입력해 주세요.")]
        [Display(Name = "아이디")]
        public string UserId { get; set; }

        [Required(ErrorMessage = "{0}를 입력해 주세요.")]
        [DataType(DataType.Password)]
        [Display(Name = "비밀번호")]
        public string Password { get; set; }

        [Display(Name = "로그인 상태 유지")]
        public bool RememberFlag { get; set; }
    }
}