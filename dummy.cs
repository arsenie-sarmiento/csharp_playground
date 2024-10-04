
/*
 using System;

class Program
{
    static void Main(string[] args)
    {
        int limit = 10; // Set the limit (number of letters to generate)
        string alphabet = GenerateAlphabet(limit);
        Console.WriteLine(alphabet);
    }

    static string GenerateAlphabet(int limit)
    {
        if (limit < 1 || limit > 26)
        {
            throw new ArgumentOutOfRangeException(nameof(limit), "Limit must be between 1 and 26.");
        }

        char start = 'A'; // Start from 'A'
        char[] letters = new char[limit];

        for (int i = 0; i < limit; i++)
        {
            letters[i] = (char)(start + i); // Generate letters sequentially
        }

        return new string(letters); // Return the result as a string
    }
}
 */

/*
 using System;

class KnightsTale
{
    static void Main()
    {
        // 27 Boxing and Unboxing: Knight's health (int) stored as object
        object knightHealthBoxed = 100; // Boxing
        int knightHealth = (int)knightHealthBoxed; // Unboxing
        Console.WriteLine($"Knight's health (Boxed): {knightHealthBoxed}, (Unboxed): {knightHealth}");

        // 28 Reflection: Getting information about the Knight's class
        Type knightType = typeof(Knight);
        Console.WriteLine($"Type: {knightType.Name}");

        // 29 Dynamic Types: A knight's current action
        dynamic currentAction = "Moving to E5";
        Console.WriteLine($"Knight's action: {currentAction}");

        // 30 Named and Optional Arguments: Knight moves with optional steps
        MoveKnight(to: "D4", steps: 2);

        // 31 When Contextual Keyword: Determine the knight's status
        int knightPosition = 3;
        string status = knightPosition switch
        {
            0 => "At Start Position",
            1 => "In Danger",
            _ => "Safe"
        };
        Console.WriteLine($"Knight's status: {status}");

        // 32 Pattern Matching: Check if the knight is on a black square
        object squareColor = "Black";
        if (squareColor is string color && color == "Black")
        {
            Console.WriteLine("Knight is on a black square!");
        }

        // 33 Ref Returns and Ref Locals: Knight's experience points
        int experiencePoints = 50;
        ref int refExperience = ref experiencePoints;
        refExperience += 10; // Increase experience via reference
        Console.WriteLine($"Knight's experience points: {experiencePoints}");

        // 34 Null-Conditional Operators: Check if knight has a shield
        string[] knightEquipment = null;
        string shield = knightEquipment?[0]; // Safe navigation
        Console.WriteLine($"Knight's shield: {shield ?? "No shield"}");

        // 35 As Operator: Attempt to cast to a special knight class
        object knightObj = new SpecialKnight();
        if (knightObj is SpecialKnight specialKnight)
        {
            Console.WriteLine($"Special Knight: {specialKnight.SpecialAbility}");
        }

        // 36 Sealed Class: Sealed Knight class
        SealedKnight sealedKnight = new SealedKnight();
        sealedKnight.DisplayMessage();

        // Error Handling: Attempt a dangerous move
        try
        {
            int moveResult = MakeMove(3, 0); // Will throw an exception
            Console.WriteLine($"Move Result: {moveResult}");
        }
        catch (InvalidMoveException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    // Method for Named and Optional Arguments
    static void MoveKnight(string to, int steps = 1)
    {
        Console.WriteLine($"Knight moves to {to} in {steps} steps.");
    }

    // Sealed Knight class example
    sealed class SealedKnight
    {
        public void DisplayMessage()
        {
            Console.WriteLine("This knight is sealed and cannot be inherited!");
        }
    }

    // Special Knight class
    class SpecialKnight
    {
        public string SpecialAbility => "Teleportation";
    }

    // Method demonstrating error handling
    static int MakeMove(int x, int y)
    {
        // Simulate an invalid move
        if (y == 0)
        {
            throw new InvalidMoveException("Knight cannot move to this position!");
        }
        return x + y; // Example move calculation
    }
}

// Custom exception for invalid moves
public class InvalidMoveException : Exception
{
    public InvalidMoveException(string message) : base(message) { }
}

 
 */

/*
 using System;

class ChessMaze
{
    static void Main()
    {
        // 27 Boxing and Unboxing
        object boxedInt = 123; // Boxing
        int unboxedInt = (int)boxedInt; // Unboxing
        Console.WriteLine($"Boxed: {boxedInt}, Unboxed: {unboxedInt}");

        // 28 Reflection
        Type type = typeof(ChessMaze);
        Console.WriteLine($"Type: {type.Name}");

        // 29 Dynamic Types
        dynamic dynamicVar = "I am dynamic!";
        Console.WriteLine(dynamicVar);

        // 30 Named and Optional Arguments
        PrintMessage(message: "Hello, World!", repeatCount: 2);

        // 31 When Contextual Keyword
        int number = 5;
        string result = number switch
        {
            0 => "Zero",
            1 => "One",
            _ => "Other"
        };
        Console.WriteLine(result);

        // 32 Pattern Matching
        object obj = "This is a string";
        if (obj is string str)
        {
            Console.WriteLine($"Pattern matched: {str}");
        }

        // 33 Ref Returns and Ref Locals
        int refVariable = 10;
        ref int refReturn = ref refVariable;
        refReturn += 5; // Modify via reference
        Console.WriteLine($"Ref modified value: {refVariable}");

        // 34 Null-Conditional Operators ?. and ?[]
        string[] names = null;
        string name = names?[0]; // Safe navigation
        Console.WriteLine($"Name: {name ?? "No name"}");

        // 35 As Operator
        object objToCast = "Cast me!";
        string castedString = objToCast as string;
        Console.WriteLine($"Casted string: {castedString}");

        // 36 Sealed Class
        SealedClass sealedObj = new SealedClass();
        sealedObj.DisplayMessage();

        // Error Handling Example
        try
        {
            int resultDivision = Divide(10, 0);
            Console.WriteLine($"Division Result: {resultDivision}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    // Method for Named and Optional Arguments
    static void PrintMessage(string message, int repeatCount = 1)
    {
        for (int i = 0; i < repeatCount; i++)
        {
            Console.WriteLine(message);
        }
    }

    // Sealed class example
    sealed class SealedClass
    {
        public void DisplayMessage()
        {
            Console.WriteLine("This is a sealed class!");
        }
    }

    // Method demonstrating error handling
    static int Divide(int numerator, int denominator)
    {
        return numerator / denominator; // May throw DivideByZeroException
    }
}

 */
