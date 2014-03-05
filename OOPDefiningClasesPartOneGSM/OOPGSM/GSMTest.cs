using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a class GSMTest to test the GSM class:
//Create an array of few instances of the GSM class.
//Display the information about the GSMs in the array.
//Display the information about the static property IPhone4S.

namespace OOPGSM
{
    class GSMTest
    {
        static void Main()
        {



            MobileDevice[] deviceLot = new MobileDevice[4];
            Battery battery = new Battery(BatteryType.LiIon, BatteryColor.Grey, 100, 10);
            Display display = new Display(256000);
            deviceLot[0] = new MobileDevice("HTC", "Desire X", 429.99m, "PEshko");
            deviceLot[1] = new MobileDevice("HTC", "One", 809.99m, "Goshko");
            deviceLot[2] = new MobileDevice("Apple", "iPhoneS4", battery, display);
            deviceLot[3] = new MobileDevice("Nokia", "Lumnia");

            foreach (var device in deviceLot)
            {
                Console.WriteLine(device.ToString());
            }

            CallHistoryTest.Test();
           
            
            
        }
    }
}
