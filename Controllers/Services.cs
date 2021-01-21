
namespace AppService.Specialist.OSS.NET._1.Controllers
{
    public class Services
    {
        public static void Copy()
        {
            CopyUtil copyUtil = new CopyUtil();
            copyUtil.SaveOnDisk();
        }
    }
}
