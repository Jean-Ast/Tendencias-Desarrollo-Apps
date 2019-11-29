using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeightReceta
{
    class CFlyWeightFactory
    {
        private List<IFlyWeight> flyweights = new List<IFlyWeight>();
        private int conteo = 0;

        public int Conteo
        {
            get => conteo;
            set => conteo = value;
        }
        public int Agregar(string pNombre)
        {
            //Verificar si existe el objeto
            bool isHere = false;
            foreach (IFlyWeight fl in flyweights)
            {
                if (fl.ObtenerNombre() == pNombre)
                {
                    isHere = true;
                }
            }
            if (isHere)
            {
                Console.WriteLine("Hey, el objeto ya existe");
                return 0;
            }
            else
            {
                CServicio servicio = new CServicio();
                servicio.ColocarNombre(pNombre);
                flyweights.Add(servicio);
                conteo = flyweights.Count;
                return conteo - 1;
            }
        }
        public IFlyWeight this[int indx]
        {
            get
            {
                return flyweights[indx];
            }
        }
    }
}
