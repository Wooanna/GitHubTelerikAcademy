using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManufacturer.Interfaces;
using FurnitureManufacturer.Models;

namespace FurnitureManufacturer.Engine.Factories
{
   public class AdjustableChair: Chair , IAdjustableChair
    {
       public AdjustableChair(string model, MaterialType materialType, decimal price, decimal height, int numOfLegs)
           : base(model, materialType, price, height, numOfLegs)
       { 
       }
        public void SetHeight(decimal height)
        {
            this.Height = height;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
