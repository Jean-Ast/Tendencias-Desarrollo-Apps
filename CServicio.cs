using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeightReceta
{
    class CServicio : IFlyWeight
    {
        private string nombre;
        private double costo;
        private double venta;
        
        public void ColocarNombre(string pNombre)
        {
            nombre = pNombre;
        }
        //Metodo que calcula el precio de cada plato
        //public void CalcularCosto()
        //{
        //    //Calculara el costo de cada plato en base al codigo ascii de la palabra
        //    foreach (Char letra in nombre)
        //    {
        //        costo += (int)letra;
        //        venta = costo * 0.18;
        //    }
        //}
        public void Mostrar()
        {
            Console.WriteLine($"- {nombre}");
        }
        public string ObtenerNombre()
        {
            return nombre;
        }
    }
}
