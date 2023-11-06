namespace _12_Operatoret_Logjik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operatoret Logjike

            //Per te kontrolluar nese dy apo me shume kushte jane true/false


            // &&  >>>>>> AND
            Console.WriteLine("T and T = " + (true && true));
            Console.WriteLine("T and F = " + (true && false));
            Console.WriteLine("F and T = " + (false && true));
            Console.WriteLine("F and F = " + (false && false));

            // ||  >>>>>> OR 
            Console.WriteLine("T or T = " + (true || true));
            Console.WriteLine("T or F = " + (true || false));
            Console.WriteLine("F or T = " + (false || true));
            Console.WriteLine("F or F = " + (false || false));


            Console.ReadKey();
        }
    }
}