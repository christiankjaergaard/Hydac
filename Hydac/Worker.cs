using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydac
{
    public class Worker
    {
        private string _workerName;
        public string WorkerName 
        {  
            get { return _workerName; } 
            set { _workerName = value; }
        }
        public Worker(string worker) 
        {
            _workerName = worker;
        }

    }
}
