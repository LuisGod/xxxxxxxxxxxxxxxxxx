using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIMER_PROYECTO_UAM.FactoryMethod
{
    //ConcreteCreator of Factory Method
    class RutaConvencional_ConcreteCreator_:Rutas_Creator_
    {
        public override void CreacionRutas()
        {
            CaracteristicasRutas.Add(new Lento_ConcreteProduct_());
            CaracteristicasRutas.Add(new Economico_ConcreteProduct_());
        }
       
    }
}
