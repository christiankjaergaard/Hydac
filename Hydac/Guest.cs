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
        private Company company;
        public Company Company
        {
            get { return company; }
            set { company = value; }
        }
        public string GuestName 
        { 
            get {  return _guestName; }
            set { _guestName = value; }
        }
       // public Visit[] visits = new Visit[10];
       // public int numberOfVisit = 0;

        public Guest(string guestName, Company company)
        {
            _guestName = guestName;
            this.company = company;
        }
        

    }
}
