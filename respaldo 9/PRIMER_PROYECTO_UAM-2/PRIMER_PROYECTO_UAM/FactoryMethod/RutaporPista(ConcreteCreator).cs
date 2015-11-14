using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIMER_PROYECTO_UAM.FactoryMethod
{
    //ConcreteCreator of Factory Method
    class RutaporPista_ConcreteCreator_:Rutas_Creator_
    {

        public override void CreacionRutas()
        {
            CaracteristicasRutas.Add(new Veloz_ConcreteProduct_());
            CaracteristicasRutas.Add(new Costoso_ConcreteProduct_());
        }

    }
}
