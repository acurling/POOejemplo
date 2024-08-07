using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    // polimorfismo

    public class animal   // clase base o clase padre
    {
        public virtual void sonidos()
        {
            Console.WriteLine("Los animales hacen sonidos");
        }
    }

    class perro : animal  // clases hijas
    {
        public override void sonidos()
        {
            Console.WriteLine("gua gua");
        }
    }

    public class cerdo : animal
    {
        public override void sonidos()
        {
            Console.WriteLine(" oing oing ");
        }
    }
    internal class Program
    {


        static void Main(string[] args)
        {

            animal Animal = new animal();
            animal Perro = new perro();
            animal Cerdo = new cerdo();

            Animal.sonidos();
            Perro.sonidos();
            Cerdo.sonidos();


            Console.ReadLine();
        }
    }
}
