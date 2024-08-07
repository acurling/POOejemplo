using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Cajero : ClsPersona, IAbrircaja, ICierrecaja
    {

        public void Abrircaja()
        {
            Console.WriteLine("Abrir la caja");
        }

        public void Cierrecaja()
        {
            Console.WriteLine("Cierre la caja");
        }
    }
}
