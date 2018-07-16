/* Write a program to generate the following matrix of palindromes of 3 letters with r rows and c columns:
        Input	Output
        3 6	    aaa aba aca	ada aea afa
                bbb bcb bdb	beb bfb bgb
                ccc cdc cec	cfc cgc chc
 * 
        2 3	    aaa aba aca
                bbb bcb bdb
 * 
        1 1	    aaa
 * 
        1 3	    aaa aba aca
 */
using System;

class MatrixOfPalindromes
{
    static void Main()
    {
        uint rows;
        Console.Write("Enter a possitive integer for the number of rows: ");
        while (!uint.TryParse(Console.ReadLine(), out rows))        // parsing and input check (validating the user data)
        {
            Console.WriteLine("Invalid number.");
            Console.Write("Please enter a possitive integer for the number of rows: ");
        }
        uint columns;
        Console.Write("Enter a possitive integer for the number of columns: ");
        while (!uint.TryParse(Console.ReadLine(), out columns))    // parsing and input check (validating the user data)
        {
            Console.WriteLine("Invalid number.");
            Console.Write("Please enter a possitive integer for the number of columns: ");
        }

        string[,] matrix = new string[rows, columns];
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                matrix[row, col] = "" + (char)('a' + row) + (char)('a' + row + col) + (char)('a' + row); 
            }
        }

        for (int row = 0; row < rows; row++)                // instead of "rows" can be "matrix.GetLength(0)"
        {
            for (int col = 0; col < columns; col++)         // instead of  "columns" can be "matrix.GetLength(1)"
            {
                Console.Write(matrix[row, col] + " ");          
            }
            Console.WriteLine();            
        }
    }
}