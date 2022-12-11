using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace aoc2022_day5
{
    internal class Command
    {
        public static int AmountMoved = 0;
        private static int FromStackTemp = 0;
        public static int FromStack => Math.Max(0, FromStackTemp - 1);
        private static int ToStackTemp = 0;
        public static int ToStack => Math.Max(0, ToStackTemp - 1);

        public static void FillVariables(string commandline)
        {
            Match match = Regex.Match(commandline, @"\d+");

            int.TryParse(match.Value, out AmountMoved);
            match = match.NextMatch();
            int.TryParse(match.Value, out FromStackTemp);
            match = match.NextMatch();
            int.TryParse(match.Value, out ToStackTemp);
        }
        public static void DebugVariables()
        {
            Console.WriteLine($"Mein Move {AmountMoved} from {FromStackTemp} to {ToStackTemp}");
        }

        public static void MoveStack(List<List<string>> grid, string line)
        {
            FillVariables(line);
            var movingStack = grid[FromStack].Take(Math.Min(AmountMoved, grid[FromStack].Count)).ToList();
            grid[FromStack].RemoveRange(0, Math.Min(AmountMoved, grid[FromStack].Count));
            foreach (var item in movingStack)
            {
                grid[ToStack].Insert(0, item);
            }
            //DebugVariables();
            //ShowStack(grid);
        }
        public static void MoveStack9001(List<List<string>> grid, string line)
        {
            FillVariables(line);
            var movingStack = grid[FromStack].Take(Math.Min(AmountMoved, grid[FromStack].Count)).ToList();
            grid[FromStack].RemoveRange(0, Math.Min(AmountMoved, grid[FromStack].Count));
            movingStack.Reverse();
            foreach (var item in movingStack)
            {
                grid[ToStack].Insert(0, item);
            }
            //DebugVariables();
            //ShowStack(grid);
        }

        public static void ShowStack(List<List<string>> grid)
        {

            //Console.Write($"{columnCounter + 1} = {grid[columnCounter].Last()}");
            Console.WriteLine(string.Join(" ", grid.Select((x, i) => x.Count > 0 ? $"{i + 1} = {x.First()}" : $"{i + 1} = (empty)")));
        }

        public static string EndStack(List<List<string>> grid)
        {
            //return string.Join("",grid.Select((x, i) => x.Count > 0 ? x.Last().Trim(new[] { '[', ']' }) : "empty"));
            return string.Join(
                "",
                grid.Select(
                    x => x.Count > 0
                        ? x.First().Trim(new[] { '[', ']' })
                        : "empty"
                )
            );
        }

    }
}
