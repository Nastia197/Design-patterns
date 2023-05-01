﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Attaker.Strategies
{
    internal class Bow : IWeapon
    {
        void IWeapon.Shoot()
        {
            Console.WriteLine("attacks with a bow");
        }
    }

}
