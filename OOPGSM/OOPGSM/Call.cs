using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//8 .Create a class Call to hold a call performed through a GSM. 
//It should contain date, time, dialed phone number and duration (in seconds).

namespace OOPGSM
{
    class Call
    {
        private int callDuration;
        private DateTime now;
        private string dialedNumber;

        public Call(int callDuration, string dialedNumber)
        {

        }

        public int CallDuration
        {
            get { return this.callDuration; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Call duration can not be a negative number");
                }
                else this.callDuration = value;
            }
        }

        public DateTime Now
        {
            get { return this.now; }
            set
            {
                this.now = value;
            }
        }

        public string DialedNumber
        {
            get { return this.dialedNumber; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("There must be a phone number");
                }
                if (value.Length < 7)
                {
                    throw new ArgumentException("Incorect phone number");
                }
                foreach (var item in value)
                {
                    if (!char.IsDigit(item))
                    {
                        throw new ArgumentException("Incorect phonenumber");

                    }
                }


                this.dialedNumber = value;

            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Date: ");
            result.Append(this.Now);
            result.Append("\nPhone number: ");
            result.Append(this.DialedNumber);
            result.Append("\nDuration: ");
            result.Append(this.CallDuration);
            return result.ToString();
        }

    }
}
