using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_and_polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Mobiles newMbl = new Mobiles()
            {
                Name = "Huawei",
                Model = "LA123"
            };
            Samsung samMbl = new Samsung()
            {
                Name = "Samsung",
                Model = "SMG935F",
                Galaxy = "Galaxy S7 Edge"
            };
            newMbl.mblModel();
            Mobiles.batteryPerformance btryPer = new Mobiles.batteryPerformance();
            btryPer.CheckBattery(9);
            samMbl.mblModel();
            newMbl.setMoreInfo(13, "Aqib Khan");
            samMbl.setMoreInfo(12, "Ahmad Khan");
            newMbl.getMoreInfo();
            samMbl.getMoreInfo();
            Mobiles newMbl2 = new Mobiles()
            {
                Name = "HTC",
                Model = "BP880IJ"
            };
            Mobiles samMbl2 = new Samsung()
            {
                Name = "Samsung",
                Model = "SMG920F",
                Galaxy = "Galaxy S6"
            };
            newMbl2.mblModel();
            samMbl2.mblModel();
            Console.ReadKey();
        }
    }
}