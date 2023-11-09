namespace _18_Metodat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Metodat

            // jane nje pjese e kodit e organizuar ne nje forme
            // qe ne mund ta therrasim (invoke) ate sa here te na nevojitet
            // metodat jane funksione nese bazohemi ne js 
            // mirpo me qe po thirren ne class ato konsiderohen si metoda

            // ne mund te deklarojme dhe japim variabla te ndryshme metodave
            // ku ato mund te kene akses ne te dhena te ndryshme

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();


            singHappyBirthday(name);
            singHappyBirthday(name);
            singHappyBirthday(name);


            Console.WriteLine(shuma(10, 15));
            Console.WriteLine( zbritja(20,25));


            // fjala return ne nje metode do te thote qe metoda duhet te
            // ktheje diqka 
            // per te perdorur return ne metode 
            // duhet te deklarojme se qfare tipi te dhenave po kthejme
            // nga metoda dhe ne vend te void duhet te deklarojme
            // tipin e te dhenave
            // 





        }

        static void singHappyBirthday (string name)
        {
            Console.WriteLine("Happy Birthday to you...");
            Console.WriteLine("Happy Birthday to you...");
            Console.WriteLine("Happy Birthday to " + name);
            Console.WriteLine("Happy Birthday to you...");
        }
        static double shuma  (double num1, double num2)
        {
            return num1 + num2;
        }
        static double zbritja (double num1 , double num2 )
        {
            return num1 - num2;
        }
    }   
}