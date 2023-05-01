using ClothesFactoryApp.Abstract_products;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClothesFactoryApp
{
    abstract class ClothesFactory
    {
        public abstract Shirt CreateShirt();

        public abstract Trousers CreateTrousers();
    }
}
