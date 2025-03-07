using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeOrnek.OdemeTipleri
{
    public class KriptoOdeme:IOdeme
    {
        public string odemeYap(string message)
        {
            return message + "ile kripto ödeme yapıldı";
        }

    }
}
