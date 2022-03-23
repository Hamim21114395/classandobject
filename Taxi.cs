using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClassanobject
{
    public class Taxi
    {
        //properties
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("DriverNam:{0}", DriverName);
            Console.WriteLine("OnDuty:{0}", OnDuty);
            Console.WriteLine("NumPassenge:{0}", NumPassenger);
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("{0}sedang menjemput penumpang", DriverName);
        }
        public void PickUpPassenger()
        { 
            Console.WriteLine("{0}selesai mengantar penumpang", DriverName);
        } 

    }
}
