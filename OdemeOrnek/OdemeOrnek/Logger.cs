using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogOrnek
{
    public class Logger
    {
        public ILogger iLogger;

        //constructor injection 
        public Logger(ILogger iLogger)
        {
            this.iLogger = iLogger;
        }

        public string LogYaz(string veri)
        {
            return iLogger.logYaz(veri);
        }
    }
}
