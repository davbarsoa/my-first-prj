using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Merci");

            int i = 0;
            uint ii = 0;

            Console.WriteLine(byte.MinValue); // 00000000 // 1 byte
            Console.WriteLine(byte.MaxValue); // 11111111


            Console.WriteLine(short.MinValue); // 1
            Console.WriteLine(short.MaxValue); //
            Console.WriteLine(ushort.MaxValue); // 11111111 11111111 unsigned short

            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(uint.MaxValue);

            Console.WriteLine(ulong.MaxValue);



            //18 446 744 073 709 551 615
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(double.MaxValue);

            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);
            //var d = 1202450.1254789625;
            
        }
    }
}