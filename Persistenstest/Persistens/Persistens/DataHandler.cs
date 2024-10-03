using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Persistens
{
    public class DataHandler
    {
        private string _dataFileName;

        public string DataFileName
        {
            get { return _dataFileName; }
        }

        public DataHandler(string dataFileName)
        {
            _dataFileName = dataFileName;
        }

        public void SavePerson(Person person) 
        {
            try
            {
                StreamWriter sw = new StreamWriter(DataFileName);
                sw.WriteLine(person.MakeTitle());
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

    }
}
