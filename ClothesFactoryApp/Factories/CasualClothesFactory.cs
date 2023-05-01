using ClothesFactoryApp.Abstract_products;
using ClothesFactoryApp.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClothesFactoryApp.Factories
{
    class CasualClothesFactory : ClothesFactory
    {
        public override Shirt CreateShirt()
        {
            return new PoloShirt();
        }

        public override Trousers CreateTrousers()
        {
            return new Jeans();
        }
        

    }
}
