using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primera_fachada
{
    class vehiculo
    {
        //atributos de la clase cliente
        private string placa;
        private string año;
        private string km;
        private string color;
        private string id_perfil;

        //metodos get y set para cada atributo de la clase. nombre siempre la primera en mayuscula
        public string Placa { get; set; }
        public string Año { get; set; }
        public string Km { get; set; }
        public string Color { get; set; }
        public string Id_perfil { get; set; }
    }
}
