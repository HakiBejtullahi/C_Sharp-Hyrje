namespace _15_Nested_For_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nested Loop

            // nje Loop brenda nje loope tjeter

            //perdoren per analizim te array 2D ose 3D 
            // ose perdorime tjera sipas nevojes


            Console.Write(" How many Rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write(" How many Columns: ");
            int cols = Convert.ToInt32(Console.ReadLine());
            

            Console.Write(" Choose Symbol: ");
            char symb = Convert.ToChar(Console.ReadLine());



            for (int i = 0; i<= rows; i++)
            {
                for (int j = 0; j <= cols; j++)
                {
                 if(i == j || i == cols -j)
                    {
                        Console.Write(" ");
                    }
                 
                    Console.Write(symb);
                }
                Console.WriteLine();

            }


            Console.ReadKey();




        }
    }
}