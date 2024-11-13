using TestInheritance;

class Program
{
    static void Main()
    {
        Knight knight = new Knight(0, 0); // Starting at (0, 0)
        var path = Pathfinding.FindPath(knight, 4, 4); // Find path to target (4, 4)

        if (path != null)
        {
            Console.WriteLine("Path to reach the target:");
            foreach (var move in path)
            {
                Console.WriteLine($"({move.Item1}, {move.Item2})");
            }
        }
        else
        {
            Console.WriteLine("No path found.");
        }
    }
}
