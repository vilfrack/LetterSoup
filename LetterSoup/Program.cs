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
                    matrix[jrow, icolumn] = Alphabet[random.Next(0, Alphabet.Length)]; 
                    contador++;
                }
            }

           // matrix[0, 0] = "LA GOLDA";
            matrix[6, 6] = "J";
            matrix[9, 9] = "A";
            matrix[8, 8] = "V";
            matrix[7, 7] = "A";
            //validar posiciones
            if (true)
            {
                int ColumPosition = random.Next(0, matrix.GetLength(0));
               int p = matrix.GetLength(0);
                if (ColumPosition == 0)
                {

                }
                ////matrix[random.Next(0, 0), random.Next(0, 10)] = "0";
                //diagonal to zero
                    matrix[0, 0] = "pe";
                    matrix[1, 1] = "pe";
                    matrix[2, 2] = "pe";
                    matrix[3, 3] = "pe";
                //horizontal to zero
                    matrix[0, 0] = "pe";
                    matrix[0, 1] = "pe";
                    matrix[0, 2] = "pe";
                    matrix[0, 3] = "pe";
                //colum to zero 
                    matrix[0, 0] = "pe";
                    matrix[1, 0] = "pe";
                    matrix[2, 0] = "pe";
                    matrix[3, 0] = "pe";
                //------------------
                //------------------
                // to four
                    matrix[0, 4] = "pa";
                    matrix[0, 5] = "pa";
                    matrix[0, 6] = "pa";
                    matrix[0, 7] = "pa";
                // down to four
                    matrix[0, 4] = "pa";
                    matrix[1, 4] = "pa";
                    matrix[2, 4] = "pa";
                    matrix[3, 4] = "pa";
                // diagonal right-down to four
                    matrix[0, 4] = "pa";
                    matrix[1, 5] = "pa";
                    matrix[2, 6] = "pa";
                    matrix[3, 7] = "pa";
                // diagonal left-down to four
                    matrix[0, 4] = "pa";
                    matrix[1, 3] = "pa";
                    matrix[2, 2] = "pa";
                    matrix[3, 1] = "pa";
                // back to four
                    matrix[0, 4] = "pa";
                    matrix[0, 3] = "pa";
                    matrix[0, 2] = "pa";
                    matrix[0, 1] = "pa";

            }



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
