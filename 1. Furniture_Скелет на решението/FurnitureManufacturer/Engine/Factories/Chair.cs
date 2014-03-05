using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManufacturer.Interfaces;
using FurnitureManufacturer.Models;

namespace FurnitureManufacturer.Engine.Factories
{
    public  class Chair : Furniture, IChair
    {
        private int numOfLegs;

        public Chair(string model, MaterialType materialType, decimal price, decimal height, int numOfLegs)
            : base(model, materialType, price, height)
        {
            this.NumberOfLegs = numOfLegs;
        }

        public int NumberOfLegs
        {
            get { return this.numOfLegs; }
            private set { this.numOfLegs = value; }
        }

        public override string ToString()
        {
            StringBuilder chair = new StringBuilder(base.ToString());
            chair.AppendFormat(", Legs: {0}", this.NumberOfLegs);
            return chair.ToString();
        }
    }
}
