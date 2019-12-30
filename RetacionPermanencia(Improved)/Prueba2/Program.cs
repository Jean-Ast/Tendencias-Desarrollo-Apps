using System;
using System.Collections.Generic;
using System.IO;

namespace Prueba2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileSplit = new string[10];
            string[] file = File.ReadAllLines($"C:\\JeanAM\\Archivos\\INTEC\\Trim Nom - Ener 2019\\Tendencias\\RetacionPermanencia(Improved)\\Eventos1.txt");
            int[] ids = new int[file.Length];
            for (int i = 0; i < file.Length; i++)
            {
                fileSplit = file[i].Split(',');
                ids[i] = Convert.ToInt32(fileSplit[0]);
            }
            DuplicateIds(ids);
            Console.ReadLine();
        }
        public static void DuplicateIds(int[] ids)
        {
            int[] list = new int[ids.Length];
            for (int i = 0; i < ids.Length; i++)
            {
                for (int j = 1; j < ids.Length; j++)
                {
                    if (ids[i]==ids[j])
                    {
                        if (idsDuplicate(ids[i]))
                        {
                            list[i] = ids[i];
                        }
                    }
                }
                if (list[i] == 0)
                {
                    Console.WriteLine($"{ids[i]} esta repetido");
                }
            }
            bool idsDuplicate (int id)
            {
                for (int i = 0; i < list.Length; i++)
                {
                    if (list[i] == id)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
