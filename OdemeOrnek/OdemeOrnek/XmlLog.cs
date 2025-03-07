using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogOrnek
{
    public class XmLog : ILogger
    {
        public string logYaz(string message)
        {
            return message + " xml e yazıldı";

        }
    }
}
