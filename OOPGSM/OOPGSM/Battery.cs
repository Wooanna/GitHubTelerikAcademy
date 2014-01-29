using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGSM
{
    class Battery
    {
        private BatteryType type;
        private int hoursIdle;
        private BatteryColor color;
        private int hoursTalk;

        public BatteryType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public BatteryColor Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public int HoursTalk
        {
            get { return hoursTalk; }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("The value must be more than 0 and less than 10");
                }
                else this.hoursTalk = value;
            }
        }

        public int HoursIdle
        {
            get { return hoursIdle; }
            set
            {
                if (value < 0 || value > 128)
                {
                    throw new ArgumentException("The value must be more than 0 and less than 128");
                }
                else this.hoursIdle = value;
            }
        }



    }
}
