using System;

public class ChessMaze
{
    public static void Main(string[] args)
    {
        // Initialize the ChessMaze game with a static maze and end position
        Knight.InitializeGame();

        // Create the Knight instance
        Knight knight = Knight.Instance;

        // Move the knight and check if it's at the end
        knight.Move(2, 3); // Move the knight to a new position
        knight.Move(5, 6); // Continue moving
        knight.CheckEnd(); // Check if the knight has reached the end
    }
}

public class Knight
{
    // Static fields
    private static Knight _instance;
    private static (int x, int y) _endCell = (7, 7); // End cell, static and constant for the game
    private static int[,] _maze; // Static maze grid, shared by all Knight instances

    // Instance fields
    private (int x, int y) _currentPosition;

    // Private constructor (ensures only one instance of Knight)
    private Knight()
    {
        _currentPosition = (0, 0); // Start from top-left corner
    }

    // Static property to access the unique Knight instance
    public static Knight Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Knight();
            }
            return _instance;
        }
    }

    // Static method to initialize the game
    public static void InitializeGame()
    {
        // Initialize the maze grid (e.g., 8x8 chessboard)
        _maze = new int[8, 8];
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                _maze[i, j] = 0; // All cells initially empty
            }
        }

        // Mark the end cell in the maze (for visualization or gameplay)
        _maze[_endCell.x, _endCell.y] = 1;
    }

    // Method to move the knight to a new position
    public void Move(int x, int y)
    {
        // Update knight's position (validation can be added)
        _currentPosition = (x, y);
        Console.WriteLine($"Knight moved to position: ({x}, {y})");
    }

    // Method to check if the knight has reached the end
    public void CheckEnd()
    {
        if (_currentPosition == _endCell)
        {
            Console.WriteLine("Congratulations! You have reached the end cell!");
        }
        else
        {
            Console.WriteLine($"Knight is at position: {_currentPosition.x}, {_currentPosition.y}. Keep going!");
        }
    }

    // Static method to get the end cell (static context)
    public static (int x, int y) EndCell => _endCell;
}
