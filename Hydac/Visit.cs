using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydac
{
    public class Visit
    {
        private DateTime checkin;
        private DateTime checkOut;
        private bool deliveredFolder;

        public DateTime CheckIn 
        {
            set { CheckIn = value; } 
        }
        public DateTime CheckOut
        {
            set { CheckOut = value; }
        }
        public bool DeliveredFolder
        {
            set { DeliveredFolder = value; }
        }

    }
}
