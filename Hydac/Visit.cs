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

        public Visit(Guest guest, Worker worker)
        {
            this.guest = guest;
            this.worker = worker;
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

        public override string ToString()           //override af ToString
        {
            return "Worker Name: " + this.worker.WorkerName + " Name: " + this.guest.GuestName + " Company: " + this.guest.Company.CompanyName + " Folder delivered = " + DeliveredFolder + " Checkin: " + CheckIn + " Checkout: " + CheckOut;
        }

        public Guest guest { get; set; }
        public Worker worker { get;  set; }
    }
}
