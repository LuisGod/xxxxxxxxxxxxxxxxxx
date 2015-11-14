using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIMER_PROYECTO_UAM
{
    class RutasBE
    {

        private string ruta;

        public string Ruta
        {
            get { return ruta; }
            set { ruta = value; }
        }

        private string  distanciakm;

        public string Distanciakm
        {
            get { return distanciakm; }
            set { distanciakm = value; }
        }

        private string  monto;

        public string Monto
        { 
            get {return monto ;} 
            set {monto = value ;} 
        }
    }
}