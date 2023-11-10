namespace _30_Overloaded_Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string suxhuk = Ingredients.sausage;
            string porshute = Ingredients.dryMeat;
            string kepurdha = Ingredients.mushrum;

            // OVERLOADED CONSTRUCTORS
            Pizza p1 = new Pizza(porshute);
            Pizza p3 = new Pizza(suxhuk);


            Pizza p2 = new Pizza(kepurdha,suxhuk);
            Pizza p4 = new Pizza(porshute,kepurdha);
            Pizza p5 = new Pizza(suxhuk,porshute);


            

            Pizza p6 = new Pizza(suxhuk,porshute,kepurdha);
            Pizza p7 = new Pizza(porshute,suxhuk,kepurdha);

            Console.WriteLine("Sorry we dont do extra!....");
            Console.ReadKey();
        }

    }



}