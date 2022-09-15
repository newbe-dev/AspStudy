using AspStudy2.Model;
using System.ComponentModel.DataAnnotations;

namespace AspStudy2.ViewModels
{
#pragma warning disable CS8618 // Nullable
    public class ActivityViewModel
    {
        public List<ActivityModel> ActivityList { get; set; }

        [Required(ErrorMessage = "{0}을 입력해 주세요.")]
        [Display(Name = "제목")]
        public string Title { get; set; }

        [Required(ErrorMessage = "{0}을 입력해 주세요.")]
        [Display(Name = "내용")]
        public string Contents { get; set; }
    }
}
