using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//1.Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, 
//battery characteristics (model, hours idle and hours talk) and display characteristics (size and number of colors). 
//Define 3 separate classes (class GSM holding instances of the classes Battery and Display).

namespace OOPGSM
{
    class MobileDevice
    {
        //6. Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S
        private static MobileDevice iPhoneS4 = new MobileDevice("Apple", "iPhoneS4");
        private string manufacturer;
        private string model;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callList;


        //2.Define several constructors for the defined classes that take different sets of arguments
        //(the full information for the class or part of it). Assume that model and manufacturer are mandatory
        //(the others are optional). All unknown data fill with null.

        public MobileDevice(string manufacturer, string model)
        {
            this.manufacturer = manufacturer;
            this.model = model;
        }

        public MobileDevice(string manufacturer, string model, decimal price, string owner)
            : this(manufacturer, model)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;

        }

        public MobileDevice(string manufacturer, string model, Battery battery, Display display, string owner = null, decimal? price = null)
            : this(manufacturer, model)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.battery = battery;
            this.display = display;

        }
        //5.Use properties to encapsulate the data fields inside the GSM, Battery and Display classes.
        //Ensure all fields hold correct data at any given time.

        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Please enter a correct model name");
                }
                else this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Please enter manufacturer");
                }
                this.manufacturer = value;
            }
        }


        public decimal? Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The price should be positive number");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                //if (value.Length <= 0 || value.Length > 50)
                //{
                //    throw new ArgumentException("Please enter correct Owner");
                //}
                 this.owner = value;
            }
        }


        //4. Add a method in the GSM class for displaying all information about it. Try to override ToString().
        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.Append("Mobile device info:");
            info.Append("\n-------------------");
            info.Append("\nManufacturer: ");
            info.Append(this.Manufacturer);
            info.Append("\nModel: ");
            info.Append(this.Model);
            info.Append("\nPrice: ");
            if (price == null)
            {
                info.Append("[ null ]");
            }
            else info.Append(this.Price);
            info.Append("\nOwner: ").ToString();
            if (owner == null)
            {
                info.Append("[ null ]");
            }
            else info.Append(this.Owner);
            info.Append(Environment.NewLine);

            if (battery != null)
            {
                info.Append(battery.ToString());
            }
            if (display != null)
            {
                info.Append(display.ToString());
            }

            return info.ToString();
        }

        //10. Add methods in the GSM class for adding and deleting calls from the calls history.
        //Add a method to clear the call history.

        public void AddCall(Call call)
        {
            if (callList == null)
            {
                callList = new List<Call>();
            }

            this.callList.Add(call);

        }

        public void DeleteCall(Call call)
        {
            this.callList.Remove(call);
        }

        public void ClearHistory()
        {
            callList.Clear();
        }

        //11. Add a method that calculates the total price of the calls in the call history.
        //Assume the price per minute is fixed and is provided as a parameter
        public decimal CalculatePrice(decimal pricePerMinute)
        {

            decimal totalPrice = 0;
            decimal duration = 0;

            if (callList != null)
            {

                foreach (var call in callList)
                {
                    duration += call.CallDuration;
                }
            }
            totalPrice = duration * (pricePerMinute / 60m);

            return totalPrice;

        }

        public decimal calculatePriceMaxOut(decimal pricePerMinute)
        {
            decimal totalPrice = 0;
            decimal duration = 0;
            int maxCallDuration = 0;
            if (callList != null)
            {
                foreach (var call in callList)
                {
                    if (call.CallDuration > maxCallDuration)
                    {
                        maxCallDuration = call.CallDuration;
                    }
                }
                foreach (var call in callList)
                {
                    duration += call.CallDuration;
                }
            }
            totalPrice = (duration - maxCallDuration) * (pricePerMinute / 60m);
            return totalPrice;

        }
    }
}
