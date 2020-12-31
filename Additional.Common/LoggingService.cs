using System;
using System.Collections.Generic;
namespace Additional.Common
{
    public static class LoggingService
    {
        public static void writeToFile(List<ILoggable> itemsLog)
        {
            foreach (var item in itemsLog)
            {
                Console.WriteLine(item.log());
            }
        }
    }
}
