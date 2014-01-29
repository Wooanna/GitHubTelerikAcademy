using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGSM
{
    class GSMMain
    {
        static void Main()
        {
            //MobileDivice gsm = new MobileDivice("Apple", "iPhone");
            //MobileDivice mobile = new MobileDivice("Nokia", "6010", 129.99m, "Ivan Ivanov");

            //string model = gsm.Model;
            //string manufacturer = gsm.Manufacturer;
            //Console.WriteLine("{0} {1}", model, manufacturer);
            //Console.WriteLine(mobile.Price);

            Battery b = new Battery();
            b.Color = BatteryColor.Black;
            b.Color = BatteryColor.White;

            Call newCall = new Call(55, "0888888888");
           
            Console.WriteLine(newCall.ToString());
        }
    }
}
