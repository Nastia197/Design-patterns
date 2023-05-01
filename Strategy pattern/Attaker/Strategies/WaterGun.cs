using System;
using System.Collections.Generic;
using System.Text;
using Attaker.Strategies;

namespace Attaker.Strategies
{
    internal class WaterGun : IWeapon
    {
        void IWeapon.Shoot()
        {
            Console.WriteLine("attacks with a water gun");
        }
    }
}
