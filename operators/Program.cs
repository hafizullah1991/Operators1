using System.Runtime.Intrinsics.X86;

namespace operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
            int a ;
            int b ;
            Console.WriteLine("enter Number1: " );
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("enter Number1: ");
            b = int.Parse(Console.ReadLine());


            int sum= a + b;
            Console.WriteLine($"{a} + {b} is  {sum}\n");


            //int quotient = a / b;
            int Quotient = a / b;
            Console.WriteLine($"{a} / {b} is {Quotient}\n");



             //int remainder = a % b;
            int remainder = a % b;
            Console.WriteLine($"{ a}/{ b} is remainder { remainder}\n");



        }
    }
}
