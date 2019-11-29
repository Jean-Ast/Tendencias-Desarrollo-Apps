using System;
using System.Collections.Generic;

namespace FlyWeightReceta
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Implementacion de FlyWeight Design Pattern
            Console.WriteLine("Jean Carlos's Restaurant!");
            List<int> Dominicana = new List<int>();

            List<int> ComidaRapida = new List<int>();

            List<int> Americana = new List<int>();

            List<int> Italiana = new List<int>();

            List<int> Ensaladas = new List<int>();

            CFlyWeightFactory flyAll = new CFlyWeightFactory();

            int i = 0;
            i = flyAll.Agregar("PolloGuisado");
            Dominicana.Add(i);

            i = flyAll.Agregar("Pavo Horneado");
            Dominicana.Add(i);

            i = flyAll.Agregar("Ensalada Mixta");
            Dominicana.Add(i);
            Ensaladas.Add(i);

            i = flyAll.Agregar("Hog Dogs");
            ComidaRapida.Add(i);
            Americana.Add(i);

            i = flyAll.Agregar("Pizza");
            ComidaRapida.Add(i);
            Italiana.Add(i);

            Console.WriteLine("*******************");
            Console.WriteLine("Comida Dominicana");
            foreach (int item in Dominicana)
            {
                CServicio comida = (CServicio)flyAll[item];
                //comida.CalcularCosto();
                comida.Mostrar();
            }
            Console.WriteLine();
            Console.WriteLine("*******************");
            Console.WriteLine("Ensaladas");

            foreach (int item in Ensaladas)
            {
                CServicio comida = (CServicio)flyAll[item];
                //comida.CalcularCosto();
                comida.Mostrar();
            }
            Console.WriteLine();
            Console.WriteLine("*******************");
            Console.WriteLine("Italiana");
            foreach (int item in Italiana)
            {
                CServicio comida = (CServicio)flyAll[item];
                //comida.CalcularCosto();
                comida.Mostrar();
            }
            Console.WriteLine();
            Console.WriteLine("*******************");
            Console.WriteLine("Comida Rapida");
            foreach (int item in ComidaRapida)
            {
                CServicio comida = (CServicio)flyAll[item];
                //comida.CalcularCosto();
                comida.Mostrar();
            }
            Console.WriteLine();
            Console.WriteLine("*******************");

            Console.WriteLine("Agregando un elemento ya insertado");
            i = flyAll.Agregar("Pizza");

            Console.WriteLine("*******************");
            Console.WriteLine("Mostrando todos los elementos de una lista");
            for (int j = 0; j < flyAll.Conteo; j++)
            {
                CServicio comida = (CServicio)flyAll[j];
                comida.Mostrar();
            }
            Console.ReadKey();
        }
    }
}
/*
                    Carnes          Ensaladas
 Dominicana         PolloGuisado    Mixta
                    Pavo Horneado
 ComidaRapida       Hog Dog
                    Hamburguesa
                    Pizza
 Americana          Hog Dog
 Italiana           PizzaPollo      Pizza
     */