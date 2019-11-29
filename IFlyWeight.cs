using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeightReceta
{
    interface IFlyWeight
    {
        void ColocarNombre(string pNombre);
        void Mostrar();
        //void CalcularCosto();
        string ObtenerNombre();
    }
}
