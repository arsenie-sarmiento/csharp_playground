/***************************************************************
    Syntax.7_passing_by_value
    Retrieved from https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/method-parameters
***************************************************************/
using System.Collections.Generic;

class EmptyCell
{
    public string? cellCharacter;
}

struct Barricade
{
    public string cellCharacter;
}
class TestClassAndStruct
{
    static void ClassTaker(EmptyCell c)
    {
        c.cellCharacter = ".";
    }

    static void StructTaker(Barricade s)
    {
        s.cellCharacter = "X";
    }

    public static void Main()
    {
        EmptyCell testClass = new();
        Barricade testStruct = new();

        // Default: Not Changed
        testClass.cellCharacter = " ";
        testStruct.cellCharacter = " ";

        ClassTaker(testClass);
        StructTaker(testStruct);

        Console.WriteLine("Class field = {0}", testClass.cellCharacter);
        Console.WriteLine("Struct field = {0}", testStruct.cellCharacter);
        PrintBoard();
        Console.ReadKey();
    }

    private static void PrintBoard()
    {
        //EmptyCell testClass = new();
        Barricade testStruct = new();
        int boardSize = 3;
        for (int a = 1; a <= boardSize; a++)
        {
            char letter = (char)('A' + a - 1);
            Console.Write($"    {letter} ");
        }
        Console.WriteLine();

        for (int i = 1; i <= boardSize; i++)
        {
            for (int h = 1; h <= boardSize; h++)
            {
                // Print inner grid: + ---
                Console.Write(" + ---");
            }

            Console.Write("+");


            Console.WriteLine();

            for (int j = 1; j <= boardSize; j++)
            {
                Console.Write($" |  {testStruct.cellCharacter}  ");

            }
            // Print the vertical row counter (DOWN / RIGHT SIDE)
            Console.Write($"| {i} ");
            Console.WriteLine();
        }
    }
}
/* Output:
    Class field = Changed
    Struct field = Not Changed
*/
