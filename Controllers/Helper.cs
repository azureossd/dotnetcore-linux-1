using System;
using System.Threading;

namespace AppService.Specialist.OSS.NET._1.Controllers
{

    public class Helper
    {

        public void SaveOnDisk()
        {
            try
            {
                CopyFiles cf = new CopyFiles();
                Thread copyThread = new Thread(new ThreadStart(cf.Execute));
                copyThread.Start();


            }
            catch (Exception ex) { }
        }

        public void WaitToFinish()
        {
            Thread.Sleep(2000);
        }
    }

    public class CopyFiles
    {
        public void Execute()
        {
            var num = 2147483647112;
            int reportnum = 1;
            for (var index = 1; index < num; index++)
            {
                reportnum = reportnum * index;
                var tmp = Math.Sqrt(reportnum);
            }
        }
    }
}