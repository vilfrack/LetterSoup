using System;

namespace LetterSoup
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Alphabet = new string[26] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

            Random random = new Random();
            Console.WriteLine("Hello World!");
            int contador = 0;
            int column = 10, row = 10;
            string[,] matrix = new string[10,10];
            for (int icolumn = 0; icolumn < column; icolumn++)
            {
                for (int jrow = 0; jrow < row; jrow++)
                {
                    matrix[icolumn, jrow] = Alphabet[random.Next(0, Alphabet.Length)]; 
                    contador++;
                }
            }

           // matrix[0, 0] = "LA GOLDA";
            matrix[6, 6] = "J";
            matrix[9, 9] = "A";
            matrix[8, 8] = "V";
            matrix[7, 7] = "A";
            



            Console.Write("\nThe matrix is : \n");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < 10; j++)
                    Console.Write("{0}\t", matrix[i, j]);
            }
            Console.Write("\n\n");
        }
    }
}
