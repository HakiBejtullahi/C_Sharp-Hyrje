namespace _05_User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Per te marre te dhena nga useri ne Console
            //perdorim metoden Console.ReadLine()
            // ne mund ta ruajm ate ne nje variabel dhe ajo
            // gjithmone ka tipin e te dhenave string

            Console.Write("Shenoni emrin: ");
            string emri = Console.ReadLine();


            Console.Write("Shenoni moshen: ");
            int age = Convert.ToInt32(Console.ReadLine());
            //Ne kete rast duhet te kemi kujdese pasi
            //qe programi pret qe useri te shtype patjeter nje numer
            // te plote int

            // nese do te provoni te shenoni nje tekst te pjesa e moshes ne console
            // do te hasni ne exception error duke thene qe nje string smund te 
            // konvertohet ne int 



            Console.WriteLine("Pershendetje " + emri + ". Mosha juaj eshte "+ age + " vjete.");

            Console.ReadKey();

        }
    }
}