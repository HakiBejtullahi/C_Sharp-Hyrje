namespace _20_Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Params 
            // mendojeni si nje array 1 dimensionale
            // pra nje liste e parametrave per nje metode
            // nese nuk e dime se sa parametra kemi

            // metode me efikase se method overloading nese kemi
            // shume parametra



            totali(4, 3.55, 25.55, 33.44);
            totali(3.99, 3.99, 5.99);




        }

        static double totali(params double [] prices)
        {
            double total = 0;

            foreach (var pr in prices) {

                total += pr;
            }
            string newTotal = total.ToString("F2");// * konverton numrin decimal
                                                   // * ne string dhe "F2" vendos
                                                   // * vetem dy numra pas pikes
                                                   // * decimale
            total = Convert.ToDouble(newTotal);


            Console.WriteLine(total);
            return total;
        }
    }
}