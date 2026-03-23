using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer
{
    static class clsEventLog
    {
        public static void EventLogExsiption(Exception e)
        {
            string sourceName = "POS_Project";

            if (!EventLog.SourceExists(sourceName))
            {
                EventLog.CreateEventSource(sourceName, "Application");
                Console.WriteLine("Event Source Created.");

            }

            EventLog.WriteEntry(sourceName, e.Message, EventLogEntryType.Error);

        }
    }
}
