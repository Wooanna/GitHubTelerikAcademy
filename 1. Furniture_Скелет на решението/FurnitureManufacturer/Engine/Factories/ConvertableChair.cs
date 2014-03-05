using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManufacturer.Interfaces;
using FurnitureManufacturer.Models;
namespace FurnitureManufacturer.Engine.Factories
{
    public class ConvertableChair : Chair, IConvertibleChair
    {
        private bool isConverted;
        private const decimal heightInConvertedState = 0.10m;
        private decimal heightNormalSate;

        public ConvertableChair(string model, MaterialType materialType, decimal price, decimal height, int numOfLegs)
            : base(model, materialType, price, height, numOfLegs)
        {
            this.isConverted = false;
            this.heightNormalSate = height;
        }

        public bool IsConverted
        {
            get { return this.isConverted; }
        }

        public void Convert()
        {
            if (!isConverted)
            {
                 this.isConverted = true;
            this.Height = heightInConvertedState;
            }
            else if(isConverted)
            {
                this.isConverted = false;
                this.Height = heightNormalSate;
                

            }
        }

        public override string ToString()
        {
            StringBuilder convChair = new StringBuilder(base.ToString());

            convChair.AppendFormat(", State: {0}", this.IsConverted ? "Converted" : "Normal");
            return convChair.ToString();
        }
    }
}
