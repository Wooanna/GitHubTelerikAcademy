﻿namespace FurnitureManufacturer.Engine.Factories
{
    using System;

    using Interfaces;
    using Interfaces.Engine;
    using Models;

    public class FurnitureFactory : IFurnitureFactory
    {
        private const string Wooden = "wooden";
        private const string Leather = "leather";
        private const string Plastic = "plastic";
        private const string InvalidMaterialName = "Invalid material name: {0}";

        public ITable CreateTable(string model, string materialType, decimal price, decimal height, decimal length, decimal width)
        {
            MaterialType materialTypeEnum = GetMaterialType(materialType);
            return new Table(model, materialTypeEnum, price, height, length, width);
           
        }

        public IChair CreateChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            MaterialType materialTypeEnum = GetMaterialType(materialType);
            return new Chair(model, materialTypeEnum, price, height, numberOfLegs);
           
        }

        public IAdjustableChair CreateAdjustableChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            MaterialType materialTypeEnum = GetMaterialType(materialType);
            return new AdjustableChair(model, materialTypeEnum, price, height, numberOfLegs);
            
        }

        public IConvertibleChair CreateConvertibleChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            MaterialType materialTypeEnum = GetMaterialType(materialType);
            return new ConvertableChair(model, materialTypeEnum, price, height, numberOfLegs);
           
        }

        private MaterialType GetMaterialType(string material)
        {
            switch (material)
            {
                case Wooden:
                    return MaterialType.Wooden;
                case Leather:
                    return MaterialType.Leather;
                case Plastic:
                    return MaterialType.Plastic;
                default:
                    throw new ArgumentException(string.Format(InvalidMaterialName, material));
            }
        }
    }
}
