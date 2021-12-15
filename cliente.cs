using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primera_fachada
{
    public class cliente
    { 
        //atributos de la clase cliente
        private string nombre;
        private string telefono;
        private string correo;
        private string direccion;
        private string numero_tarjeta;
     
        //metodos get y set para cada atributo de la clase
        public string Nombre { get; set;}
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public string Numero_Tarjeta { get; set; }

    }
}
