namespace _08_NumriRrendomt
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Krijo numra te rrendomt. 

            // Random r1  = new Random() Deklaron nje objekt 
            // i cili permban metoda per te marr nje nummer 
            // te rendomt ne kode
            //metoda .next(start,finish + 1) => nese duam numrat 1 deri 6

            Random  r1 = new Random();
            int num1 = r1.Next(1,7);
            int num2 = r1.Next(1,7);
            int num3 = r1.Next(1,7);
            Console.WriteLine(num1 + " " + num2 + " " + num3);


            double dec1 = r1.NextDouble();
            Console.WriteLine(dec1);
            Console.ReadKey();

        }
    }
}