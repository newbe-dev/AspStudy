using AspStudy2.Model;

namespace AspStudy2.IDAL
{
    public interface IActivityDal
    {
        /// <summary>
        /// 활동 내역 리스트를 내림차순으로 가져온다.
        /// </summary>
        /// <returns></returns>
        List<ActivityModel> GetActivityList();
        
        /// <summary>
        /// 활동 내역 하나를 가져온다.
        /// </summary>
        /// <param name="id">활동 ID</param>
        /// <returns></returns>
        ActivityModel? GetActivity(int id);
        
        /// <summary>
        /// 활동을 게시한다.
        /// </summary>
        /// <param name="newActivity">활동</param>
        /// <returns>게시 성공 여부</returns>
        bool PostActivity(ActivityModel newActivity);
        
        /// <summary>
        /// 활동을 업데이트한다.
        /// </summary>
        /// <param name="newActivity">활동</param>
        /// <returns>업데이트 성공 여부</returns>
        bool UpdateActivity(ActivityModel newActivity);
        
        /// <summary>
        /// 활동을 제거한다.
        /// </summary>
        /// <param name="id">활동 ID</param>
        /// <returns>제거 성공 여부</returns>
        bool DeleteActivity(int id);
    }
}