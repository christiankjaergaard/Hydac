using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydac
{
    public class Visit
    {
        private DateTime _checkIn;
        private DateTime checkOut;
        private bool deliveredFolder;

        public Visit()
        {
             _checkIn = DateTime.Now; 
        }

        public DateTime CheckIn 
        {
            set { _checkIn = DateTime.Now; }
            get { return _checkIn; }             
        }
        
        public DateTime CheckOut
        {
            set { CheckOut = value; }
        }
        /*public DateTime CheckOut(double value)
        {
            return checkOut;
        }*/

        public bool DeliveredFolder
        {
            set { DeliveredFolder = value; }
        }

    }
}
