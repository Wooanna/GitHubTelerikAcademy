using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManufacturer.Interfaces;
using FurnitureManufacturer.Models;

namespace FurnitureManufacturer.Engine.Factories
{
    public class Table : Furniture, ITable
    {
        private decimal length;
        private decimal width;
        private decimal area;
        public Table(string model, MaterialType materialType, decimal price, decimal height, decimal length, decimal width)
            : base(model, materialType, price, height)
        {
            this.Length = length;
            this.Width = width;
            this.area = length * width;
        }
        public decimal Length
        {
            get { return this.length; }
            private set {
                if (value == null)
                {
                    throw new ArgumentNullException("value cannot be null");
                }
                this.length = value; }
        }

        public decimal Width
        {
            get { return this.width; }
            private set {
                if (value == null)
                {
                    throw new ArgumentNullException("value cannot be null");
                }
                    this.width = value; }
        }

        public decimal Area
        {
            get { return this.area; }

        }

        public override string ToString()
        {
            StringBuilder table = new StringBuilder(base.ToString());
            table.AppendFormat(", Length: {0}, Width: {1}, Area: {2}", this.Length, this.Width, this.Area);
            return table.ToString();
        }
    }
}
