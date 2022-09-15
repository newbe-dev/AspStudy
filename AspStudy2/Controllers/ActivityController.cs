using AspStudy2.BLL;
using AspStudy2.Model;
using AspStudy2.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspStudy2.Controllers
{
    public class ActivityController : Controller
    {
        private readonly ActivityBll _activityBll;
        public ActivityController(ActivityBll activityBll)
        {
            _activityBll = activityBll;
        }

        public IActionResult Index()
        {
             var activityList = _activityBll.GetActivityList();
            return View(new ActivityViewModel()
            {
                ActivityList = activityList,
            });
        }

        [HttpPost]
        public IActionResult Add(ActivityViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            ActivityModel newActivity = new()
            {
                Title = model.Title,
                Contents = model.Contents,
                IsModified = false,
                WrittenDate = DateTime.Now,
            };
            _activityBll.PostActivity(newActivity);
            return RedirectToAction("Index", "Activity");
        }

        [HttpPost]
        public IActionResult Delete()
        {
            return RedirectToAction("Index", "Activity");
        }
    }
}
