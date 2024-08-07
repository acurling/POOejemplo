using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Clsmenu
    {
        private int opcion = 0;
        public void Desplegar()
        {
            Console.WriteLine("1 opcion");
            Console.WriteLine("2 opcion");
            Console.WriteLine("3 opcion");
            Console.WriteLine("Digite una opcion:..");
            opcion = int.Parse(Console.ReadLine());
        }
    }
}
