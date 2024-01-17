using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Weapon
    {
       abstract public void Fire();

    }

    class Player
    {
        public void Fire(Weapon weapon)
        {
            weapon.Fire();
        }
    }

    class Gun : Weapon
    {
        public override void Fire()
        {
            Console.WriteLine(" ПЫЩ ПЫЩ !!!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Fire(new Gun());
        }
    }
}
