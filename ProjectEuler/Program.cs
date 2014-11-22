using System;
using System.Linq;
using System.Reflection;

/// <summary>
/// Solutions to Project Euler challenge problems.
/// </summary>
namespace ProjectEuler
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // print availability grid
            Console.WriteLine(new string('-', 65));

            for (int i = 0; i < 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    string problem = (10 * i + j).ToString().PadLeft(3, '0');
                    try 
                    { 
                        var type = Assembly.GetExecutingAssembly().GetTypes().First(t => t.Name == ('_' + problem));
                        if (type != null) { Console.Write(" {0} ", problem); }
                    }
                    catch { Console.Write("  X  "); }
                }
                Console.WriteLine();
            }

            while (true)
            {
                Console.WriteLine(new string('-', 65));
                Console.WriteLine("Enter the problem you would like to solve (001 through 489):"); 

                string problem = Console.ReadLine().PadLeft(3, '0');
                Console.WriteLine();

                try
                {
                    // check to see if that problem has been implemented
                    var type = Assembly.GetExecutingAssembly().GetTypes().First(t => t.Name == ('_' + problem));
                    Console.Write("Solution: ");
                    Activator.CreateInstance(type); 
                }
                catch
                {
                    Console.WriteLine("I haven't solved that one yet!"); 
                }

                Console.Write("\n Continue? [y/n]: ");

                var status = Console.ReadLine();
                if (status.ToUpper() == "N") { break; }
            }
        }
    }
}

