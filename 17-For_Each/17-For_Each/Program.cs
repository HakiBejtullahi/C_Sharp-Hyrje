namespace _17_For_Each
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //foreach loop 
            // kjo loop perdoret per te iteruar nje liste
            // ka sintaks me te lehte se for loop
            // me pak fleksibile

            string[] cars = new string[5];

            //for loop
            for (int i = cars.Length - 1 ;i >=0 ; i--)
            {
                Console.Write("Sheno nje brend te vetures: ");
                cars[i] = Console.ReadLine();
            }

            //foreach loop

            foreach (string car in cars) {
                Console.WriteLine("Brand: " + car);
            }


        }
    }
}