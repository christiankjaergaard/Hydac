using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydac
{
    public class Guest
    {
        private string _guestName;
         
        public string GuestName 
        { 
            get {  return _guestName; }
            set { _guestName = value; }
        }
        public Guest(string guestName)
        {
            _guestName = guestName;
        }


    }
}
