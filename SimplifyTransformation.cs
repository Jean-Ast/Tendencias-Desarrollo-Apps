using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_2
{
    class Program
    {
        public static string FirstLetterToUpper(string word)
        {
            if (word.Equals(""))
            {
                return word;
            }
            return char.ToUpper(word[0]) + word.Substring(1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Transformación de cadenas");
            //SimplifyTransformation “Upper->Lower->Upper”
            string input, input1, input2, input3, input4;
            //  Presentacion de los casos de prueba
            input = "jean carlos astacio mejia - 1073416";
            input1 = "      jean carlos astacio mejia - 1073416   ";
            input2 = "   jeAn CarlOS astaCio meJia - 1073416   ";
            input3 = "   je  an Car los ast acio me jia - 1073416   ";
            input4 = "      jean     Carlos     astacio     mejia     -     1073416      ";

            //Lower --> Upper
            Console.WriteLine("LowerToUpper");
            Console.WriteLine($"{input.ToUpper()} --> {input.ToLower()} --> {input.ToUpper()}");
            Console.WriteLine($"{input1.ToUpper()} --> {input1.ToLower()} --> {input1.ToUpper()}");
            Console.WriteLine($"{input2.ToUpper()} --> {input2.ToLower()} --> {input2.ToUpper()}");
            Console.WriteLine($"{input3.ToUpper()} --> {input3.ToLower()} --> {input3.ToUpper()}");
            Console.WriteLine($"{input4.ToUpper()} --> {input4.ToLower()} --> {input4.ToUpper()}");
            Console.WriteLine();

            //Camel->Pack->Snake === Camel->Pack
            char[] charPackCadena = input.ToCharArray();
            string.Join(" ", input.Split(' ').Select(w => FirstLetterToUpper(w)));

            //Trim
            Console.WriteLine("LTrim --> RTrim === Trim");
            char[] charTrimInput = input.ToCharArray();
            for (int i = 0; i < charTrimInput.Length; i++)
            {
                Console.Write(charTrimInput[i].ToString().Replace(" ", string.Empty));
            }
            Console.WriteLine();
            char[] charTrimInput1 = input1.ToCharArray();
            for (int i = 0; i < charTrimInput1.Length; i++)
            {
                Console.Write(charTrimInput1[i].ToString().Replace(" ", string.Empty));
            }
            Console.WriteLine();
            char[] charTrimInput2 = input2.ToCharArray();
            for (int i = 0; i < charTrimInput2.Length; i++)
            {
                Console.Write(charTrimInput2[i].ToString().Replace(" ", string.Empty));
            }
            Console.WriteLine();
            char[] charTrimInput3 = input3.ToCharArray();
            for (int i = 0; i < charTrimInput3.Length; i++)
            {
                Console.Write(charTrimInput3[i].ToString().Replace(" ", string.Empty));
            }
            Console.WriteLine();
            char[] charTrimInput4 = input4.ToCharArray();
            for (int i = 0; i < charTrimInput4.Length; i++)
            {
                Console.Write(charTrimInput4[i].ToString().Replace(" ", string.Empty));
            }
            Console.ReadKey();
        }
    }
}
