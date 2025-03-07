using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogOrnek
{
    public class DbLog : ILogger
    {
        public string logYaz(string message)
        {
            return message + " db ye yazıldı";
            
        }
    }
}
