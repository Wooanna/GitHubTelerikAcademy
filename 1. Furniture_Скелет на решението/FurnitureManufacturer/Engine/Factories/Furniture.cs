using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManufacturer.Interfaces;
using FurnitureManufacturer.Models;


namespace FurnitureManufacturer.Engine.Factories
{
    public abstract class Furniture : IFurniture
    {
        private string model;
        private string material;
        private MaterialType materialType;
        private decimal price;
        private decimal height;

        public Furniture(string model, MaterialType materialType, decimal price, decimal height)
        {
            this.Model = model;
            this.materialType = materialType;
            this.Price = price;
            this.Height = height;
            
        }
        public string Model
        {
            get { return this.model; }
            protected set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 3)
                {
                    throw new ArgumentNullException("Model name must be more than 3 symbols long.");
                }
                this.model = value;
            }
        }

        public string Material
        {
            get { return this.material; }
            protected set
            {
                this.material = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
             set
            {
                if (value <= 0 )
                {
                    throw new ArgumentException("Price cannot be less or equal to $0.00.");
                }
                this.price = value;
            }
        }

        public decimal Height
        {
            get { return this.height; }
            protected set
            {
                if ( value <= 0 )
                {
                    throw new ArgumentException("Height cannot be less or equal to 0.00 m");
                } this.height = value;
            }
        }

        public override string ToString()
        {
            StringBuilder furniture = new StringBuilder();
            furniture.AppendFormat("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}",
                this.GetType().Name, this.Model, this.materialType, this.Price, this.Height);
            return furniture.ToString();
        }
    }
}
