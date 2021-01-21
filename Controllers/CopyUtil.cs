using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading;

namespace AppService.Specialist.OSS.NET._1.Controllers
{
    public class CopyUtil
    {

        private static void SaveFile(object number)
        {
            var num = Convert.ToInt32(number);
            int reportnum = 1;
            for (var index = 1; index < num; index++)
            {
                reportnum = reportnum * index;
                var tmp = Math.Sqrt(reportnum);
            }
        }

        public void SaveOnDisk()
        {
            try
            {
                int time = 60000;
                List<Thread> threads = new List<Thread>();
                for (int j = 0; j < Environment.ProcessorCount; j++)
                {
                    Thread t = new Thread(new ParameterizedThreadStart(SaveFile));
                    t.Start(2147483647);
                    threads.Add(t);
                }

                Thread.Sleep(time);
                foreach (var t in threads)
                {
                    t.Abort();
                }
            }
            catch (Exception ex)
            {

            }

        }
    }
}
