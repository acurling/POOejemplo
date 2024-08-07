using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Clsprofesor :  ClsPersona
    {

        Clscurso cursos = new Clscurso();
        Clsdireccion ubicacion = new Clsdireccion();  // instancia de la clase
        public  float salario { get; set; }

        // delimitadores de acceso = public privado y protegido
        public void Consultar()
        {
            Console.WriteLine(cursos.codigo + cursos.decripcion + cursos.horario +  salario + direccion + nombre + cedula);
            AgregarPersonas();
            edad = 40;
            ubicacion.provincia = "san jose";
            ubicacion.distrito = "distrito";
            ubicacion.calle = "Calle central";

            cursos.Agregarcurso();
        }
    }
}
