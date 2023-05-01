using System;
using System.Collections.Generic;
using System.Text;
using ClothesFactoryApp.Abstract_products;

namespace ClothesFactoryApp
{
    class Client
    {
        private readonly Shirt _shirt;
        private readonly Trousers _trousers;

        public Client(ClothesFactory factory)
        {
            _shirt = factory.CreateShirt();
            _trousers = factory.CreateTrousers();
        }
        
        public string DescribeYourClothes()
        {
            return $" {_shirt.GetType().Name} and {_trousers.GetType().Name}";
        }

    }
}
