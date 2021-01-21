
namespace AppService.Specialist.OSS.NET._1.Controllers
{
    public class Services
    {
        public static void Copy()
        {
            Helper copyUtil = new Helper();
            copyUtil.SaveOnDisk();
            copyUtil.WaitToFinish();
        }
    }
}
