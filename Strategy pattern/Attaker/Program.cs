using System;
using Attaker.Strategies;


namespace Attaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero ("Fighter");


            hero.SetWeapon(new Bow());

            hero.Attack();


            //hero.SetWeapon(new Sword());

            //hero.Attack();


            Console.ReadLine();


        }
    }
}
