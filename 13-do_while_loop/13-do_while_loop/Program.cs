namespace _13_do_while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1  = 0;
            double num2 = 0;
            bool contLoop = true;
            string userAnswer = string.Empty;

            do
            {
                Console.WriteLine("Wellcome to adding calc.");
                Console.WriteLine();
                Console.WriteLine();
                bool firstLoop = true;
                bool secLoop = true;
                while (firstLoop)
                {

                Console.Write("Enter first number: ");
                if (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Please enter a correct value for a number.");
                    continue;
                }

                Console.Write("Enter second number: ");
                if (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Please enter a correct value for a number.");
                        continue;
                }

                double res = Shuma(num1, num2);
                Console.WriteLine("Rezultati: {0} + {1} = {2}",num1,num2,res);
                firstLoop = false;
                }
                while (secLoop)
                {

                Console.Write("Want to try again(answer yes/ no): ");
                userAnswer = Console.ReadLine().ToLower();

                if (!userAnswer.Equals("yes") && !userAnswer.Equals("no"))
                {
                    Console.WriteLine("Please enter only yes or no.");
                }
                else if (userAnswer.Equals("yes"))
                {
                    firstLoop = true;
                    secLoop = false;
                }
                else if (userAnswer.Equals("no"))
                {
                    secLoop = false;
                    contLoop = false;
                 }
                else
                {
                    Console.WriteLine("Something went wrong");
                    secLoop = false;
                    contLoop = false;

                }

                }
                


            } while (contLoop);




        }
        static public double Shuma (double a, double b)
        {
             return a + b;
        }

}
}