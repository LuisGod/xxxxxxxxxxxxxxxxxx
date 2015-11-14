using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIMER_PROYECTO_UAM
{
    public class ConductorBE
    {
               
        private string placa;

        public string Placa { get { return placa; } set { placa = value; } }

        private string año;

        public string Año { get { return año; } set { año = value; } }

        private string color;

        public string Color { get { return color; } set { color = value; } }

        private string nombres;

        public string Nombres { get { return nombres; } set { nombres = value; } }

        private string apellidos;

        public string Apellidos { get { return apellidos; } set { apellidos = value; } }

        private string dni;

        public string DNI { get { return dni; } set { dni = value; } }

        private string edad;

        public string Edad { get { return edad; } set { edad = value; } }

        private string direccion;

        public string Direccion { get { return direccion; } set { direccion = value; } }

        private string provincia;

        public string Provincia { get { return provincia; } set { provincia = value; } }

    }
}
