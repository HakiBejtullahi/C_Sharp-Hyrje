namespace _01_Hyrje_Output
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ndro ngjyrat e Consoles
            // Ndrro ngjyren e shkronjave ne Console
            Console.ForegroundColor = ConsoleColor.Red;
            // Ndrro ngjyren e background te tekstit ne Console
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            // Ndrro ngjyren e background ne Console
            // kujdes fshine gjitha tekstet
            Console.Clear();


            //Per te shfaqur nje mesazh ne Console perdorim keto dy metoda


            // Console.Write()  => per te shenuar tekst ne console pa e zene gjithe rreshtin
            Console.Write("Fjala 1");
            Console.Write("Fjala 2");

            //Console.WriteLine()  => per te shenuar tekst ne console duke zene gjithe rreshtin
            Console.WriteLine( );
            Console.WriteLine(" Fjala 3");
            Console.WriteLine(" Fjala 4");



            //Console.ReadKey() perdoret per te larguar nje warning ne Console
            Console.ReadKey();

        }
    }
}