using AspStudy2.IDAL;
using AspStudy2.Model;

namespace AspStudy2.BLL
{
    public class ActivityBll : IActivityDal
    {
        private readonly IActivityDal _activityDal;
        public ActivityBll(IActivityDal activityDal)
        {
            _activityDal = activityDal;
        }

        public List<ActivityModel> GetActivityList()
        {
            return _activityDal.GetActivityList();
        }

        public ActivityModel? GetActivity(int id)
        {
            if(id <= 0) return null;
            return _activityDal.GetActivity(id);
        }

        public bool PostActivity(ActivityModel newActivity)
        {
            if(NullCheck(newActivity)) return false;
            return _activityDal.PostActivity(newActivity);
        }

        public bool UpdateActivity(ActivityModel newActivity)
        {
            if (NullCheck(newActivity)) return false;
            return _activityDal.UpdateActivity(newActivity);
        }

        public bool DeleteActivity(int id)
        {
            if (id <= 0) return false;
            return _activityDal.DeleteActivity(id);
        }

        private static bool NullCheck(ActivityModel activity) => (activity is null || activity.Title is null /*|| activity.Contents is null*/ );
    }
}