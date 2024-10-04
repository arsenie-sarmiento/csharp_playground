/***************************************************************
    Syntax.7_passing_by_value
    Retrieved from https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/method-parameters
***************************************************************/
using System.Collections.Generic;

class EmptyCell
{
    public string? willIChange;
}

struct Barricade
{
    public string willIChange;
}
class TestClassAndStruct
{
    static void ClassTaker(EmptyCell c)
    {
        c.willIChange = "Changed";
    }

    static void StructTaker(Barricade s)
    {
        s.willIChange = "Changed";
    }

    public static void Main()
    {
        EmptyCell testClass = new();
        Barricade testStruct = new();

        testClass.willIChange = "Not Changed";
        testStruct.willIChange = "Not Changed";

        ClassTaker(testClass);
        StructTaker(testStruct);

        Console.WriteLine("Class field = {0}", testClass.willIChange);
        Console.WriteLine("Struct field = {0}", testStruct.willIChange);
        Console.ReadKey();
    }
}
/* Output:
    Class field = Changed
    Struct field = Not Changed
*/

