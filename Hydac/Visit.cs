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
        private DateTime _checkOut;
        private bool _deliveredFolder;

        public Visit()
        {


        }

        public DateTime CheckIn 
        {
            set { _checkIn = DateTime.Now; }
            get { return _checkIn; }             
        }
        
        public DateTime CheckOut
        {
            set { _checkOut = value; }
            get { return _checkOut; }
        }

        public bool DeliveredFolder
        {
            set { _deliveredFolder = value; }
            get { return _deliveredFolder; }
        }

    }
}
