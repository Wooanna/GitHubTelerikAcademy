using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGSM
{
    class Battery
    {
        //fields
        private BatteryType? type;
        private int? hoursIdle;
        private BatteryColor? color;
        private int? hoursTalk;

        //constructor
        public Battery(BatteryType? type = null, BatteryColor? color = null, int? hoursIdle = null, int? hoursTalk = null)
        {
            this.type = type;
            this.color = color;
            this.hoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        //properties
        public BatteryType? Type
        {
            get { return type; }
            set { this.type = value; }
        }

        public BatteryColor? Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public int? HoursTalk
        {
            get { return hoursTalk; }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("The value must be more than 0 and less than 20");
                }
                else this.hoursTalk = value;
            }
        }

        public int? HoursIdle
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

        public override string ToString()
        {
            StringBuilder batteryInfo = new StringBuilder();
            batteryInfo.Append("-------- ");
            batteryInfo.Append("\nBattery: ");
            batteryInfo.Append("\n-------- ");
            batteryInfo.Append("\nBattery Type: ");
            batteryInfo.Append(this.Type);
            batteryInfo.Append("\nHours Talk: ");
            batteryInfo.Append(this.hoursTalk);
            batteryInfo.Append("\nHours Idle: ");
            batteryInfo.Append(this.HoursIdle);
            batteryInfo.Append("\nColor: ");
            batteryInfo.Append(this.Color);
            batteryInfo.Append(Environment.NewLine);
            return batteryInfo.ToString();
        }
    }
}
