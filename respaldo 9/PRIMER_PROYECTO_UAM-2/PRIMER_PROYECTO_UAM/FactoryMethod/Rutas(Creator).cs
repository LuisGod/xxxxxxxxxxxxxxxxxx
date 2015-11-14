using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIMER_PROYECTO_UAM
{
    //Creator of Factory Method

    abstract class Rutas_Creator_
    {
        private List<CaracteristicasRutas_Product_> caracteristicasRutas = new List<CaracteristicasRutas_Product_>();

        // Constructor calls abstract Factory method

       public abstract void CreacionRutas();

       public Rutas_Creator_()
       {
           this.CreacionRutas();
       }

       public List<CaracteristicasRutas_Product_> CaracteristicasRutas
        {
            get { return caracteristicasRutas; }
        }

    }
}
