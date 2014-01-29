using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, 
//battery characteristics (model, hours idle and hours talk) and display characteristics (size and number of colors). 
//Define 3 separate classes (class GSM holding instances of the classes Battery and Display).

namespace OOPGSM
{
    class MobileDivice
    {
        private MobileDivice iPhoneS4 = new MobileDivice("Apple", "iPhoneS4");
        private string manufacturer;
        private string model;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callList;

        public MobileDivice(string manufacturer, string model)
        {
            this.manufacturer = manufacturer;
            this.model = model;
        }

        public MobileDivice(string manufacturer, string model, decimal price, string owner)
            : this(manufacturer, model)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
           
        }

        public MobileDivice(string manufacturer, string model, decimal price, string owner, Battery battery, Display display)
            : this(manufacturer, model)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;

        }

        public string Model
        {
            get { return this.model; }
            set  {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Please enter a correct model name"); 
                } 
                else   this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer;  }
            set {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Please enter manufacturer");
                }
                this.manufacturer = value; }
        }


        public decimal Price
        {
            get { return this.price; }
            set {
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
            get { return this.Owner; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Please enter correct Owner");
                }
                else this.Owner = owner;
            }
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            
            return info.ToString();
        }



    }
}
