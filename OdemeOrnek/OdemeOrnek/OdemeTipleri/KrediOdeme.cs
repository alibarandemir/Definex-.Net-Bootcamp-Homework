using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeOrnek.OdemeTipleri
{
    public class KrediOdeme: IOdeme
    {
        public string odemeYap(string message)
        {
            return message +"ile ödeme yapıldı";
        }
    }
    
}
