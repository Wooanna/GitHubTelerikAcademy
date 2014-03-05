using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer
{
    public class Company : ICompany
    {
        private string name;
        private string registrationNumber;
        private const int regNumberLength = 10;

        private ICollection<IFurniture> furnitures;

        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
            this.furnitures = new List<IFurniture>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 5)
                {
                    throw new ArgumentNullException("Name cannot be null or empty or less than 5 symbols");
                }
                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get { return this.registrationNumber; }
            private set
            {
               
                if (value.Length != regNumberLength)
                {
                    throw new ArgumentException("Registration nunmber must be exactly 10 symbols.");
                }
                for (int i = 0; i < value.Length; i++)
                {
                    if (!Char.IsDigit(value[i]))
                    {
                        throw new ArgumentException("Registration nunmber must contain only digits");
                    }
                }
                this.registrationNumber = value;
            }
        }

        public ICollection<IFurniture> Furnitures
        {
            get { return this.furnitures; }
        }

        public void Add(IFurniture furniture)
        {
            this.furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            if (this.furnitures.Contains(furniture))
            {
                this.furnitures.Remove(furniture);
            }
           // var item = this.furnitures.FirstOrDefault(x => x.Material == furniture.Material && x.Model == furniture.Model && x.Price == furniture.Price);


            
        }

        public IFurniture Find(string model)
        {
            foreach (var furn in furnitures)
            {
                if (furn.Model == model)
                {
                    return furn;
                }
               
            }
            return null;
        }

        public string Catalog()
        {
            StringBuilder catalog = new StringBuilder();
            catalog.AppendFormat("{0} - {1} - ", this.Name, this.RegistrationNumber);
            if (this.furnitures.Count <= 0)
            {
                catalog.Append("no furnitures");
            }
            else if (this.furnitures.Count == 1)
            {
                catalog.Append("1 furniture\n");
                foreach (var furn in furnitures)
                {
                    catalog.Append(furn.ToString());
                }
            }
            else
            {
                catalog.AppendFormat("{0} furnitures\n", this.furnitures.Count);
               var orderedFurnitures =  furnitures.OrderBy(x => x.Price).ThenBy(x => x.Model);
                foreach (var furn in orderedFurnitures)
                {
                        catalog.AppendFormat("{0}", string.Join("\n",furn.ToString()));
                }
            }

            return catalog.ToString();
        }
    }
}
