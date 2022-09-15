using AspStudy2.DAL.DataContext;
using AspStudy2.IDAL;
using AspStudy2.Model;

namespace AspStudy2.DAL
{
    public class ActivityDal : IActivityDal
    {
        private readonly AspStudy2DbContext _context;
        public ActivityDal(AspStudy2DbContext context)
        {
            _context = context;
        }

        public List<ActivityModel> GetActivityList()
        {
            return _context.Activity.OrderByDescending(x => x.Id).ToList();
        }

        public ActivityModel? GetActivity(int id)
        {
            return _context.Activity.FirstOrDefault(x => x.Id.Equals(id));
        }

        public bool PostActivity(ActivityModel newActivity)
        {
            _context.Activity.Add(newActivity);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateActivity(ActivityModel newActivity)
        {
            var targetActivity = _context.Activity.Find(newActivity.Id);
            if (targetActivity is null) return false;
            
            targetActivity.Title = newActivity.Title;
            targetActivity.Contents = newActivity.Contents;
            targetActivity.WrittenDate = newActivity.WrittenDate;
            targetActivity.IsModified = true;

            _context.SaveChanges();
            return true;
        }

        public bool DeleteActivity(int id)
        {
            var targetActivity = _context.Activity.Find(id);
            if (targetActivity is null) return false;

            _context.Remove(targetActivity);
            _context.SaveChanges();
            return true;
        }
    }
}