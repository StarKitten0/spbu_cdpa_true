using System;

namespace MatrixMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string paths1 = args[0];
                string paths2 = args[1];
                Matrix factors1 = MatrixReader.Read(paths1);
                Matrix factors2 = MatrixReader.Read(paths2);
                Console.WriteLine(factors1 * factors2);
            }
            catch (IndexOutOfRangeException)
            {
                Console.Error.WriteLine("paths to factors must be given");
            }
        }
    }
}
