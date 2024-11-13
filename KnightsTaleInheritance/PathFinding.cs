using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInheritance
{
    public class Pathfinding
    {
        public static List<Tuple<int, int>> FindPath(Knight knight, int targetRow, int targetCol)
        {
            var directions = new List<Tuple<int, int>>()
        {
            new Tuple<int, int>(-2, -1),
            new Tuple<int, int>(-2, 1),
            new Tuple<int, int>(-1, -2),
            new Tuple<int, int>(-1, 2),
            new Tuple<int, int>(1, -2),
            new Tuple<int, int>(1, 2),
            new Tuple<int, int>(2, -1),
            new Tuple<int, int>(2, 1)
        };

            var queue = new Queue<Tuple<int, int>>();
            var visited = new HashSet<Tuple<int, int>>();
            var parentMap = new Dictionary<Tuple<int, int>, Tuple<int, int>>();

            queue.Enqueue(new Tuple<int, int>(knight.CurrentRow, knight.CurrentCol));
            visited.Add(new Tuple<int, int>(knight.CurrentRow, knight.CurrentCol));

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                var (row, col) = current;

                if (row == targetRow && col == targetCol)
                {
                    var path = new List<Tuple<int, int>>();
                    while (parentMap.ContainsKey(current))
                    {
                        path.Add(current);
                        current = parentMap[current];
                    }
                    path.Reverse();
                    return path;
                }

                foreach (var dir in directions)
                {
                    int newRow = row + dir.Item1;
                    int newCol = col + dir.Item2;
                    var newPos = new Tuple<int, int>(newRow, newCol);

                    if (Board.IsValidMove(newRow, newCol) && !visited.Contains(newPos))
                    {
                        visited.Add(newPos);
                        parentMap[newPos] = current;
                        queue.Enqueue(newPos);
                    }
                }
            }

            return null; // No path found
        }
    }

}
