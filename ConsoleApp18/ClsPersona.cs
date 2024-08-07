using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class ClsPersona
    {
        // atributos
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }

        protected int edad;



        // constructor 
        public ClsPersona(string cedula, string nombre, string direccion)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.direccion = direccion;
        }

        public ClsPersona() 
        {
            this.cedula = "11";
            this.nombre = "Marta";
            this.direccion = "San jose";
        }


        public ClsPersona(string cedula)
        {
            this.cedula = cedula;
        }

        // metodos o funciones 

        //CRUD
        /* C = create
         * R = Read
         * U= update
         * D = Delete
         */
       public void AgregarPersonas()
        {
            Console.WriteLine("Digite La cedula");
            cedula = Console.ReadLine();
            Console.WriteLine("Digite el nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Digite la direccion");
            direccion = Console.ReadLine();
            edad = 20;
        }

       public void ModificarPersonas()
        {

        }

        void ConsultarPersonas()
        {
            Console.WriteLine(edad);
        }

        void EliminarPersonas()
        {
            edad = 0;
        }


    }
}
