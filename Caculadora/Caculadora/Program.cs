using System;

namespace Caculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Introduzca el primer número");
            var line = Console.ReadLine();
            int int1 = System.Int32.Parse(line);

            Console.WriteLine("Introduzca el segundo número");
            line = Console.ReadLine();
            int int2 = Int32.Parse(line);

            var result = new Add().AddNumbers(int1, int2);

            Console.WriteLine(string.Format("Resultado: {0}", result));
        }
    }
}
