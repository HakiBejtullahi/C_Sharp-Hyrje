namespace _07_Klasa_Math
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double x = 3;


            //Klasa Math permban metoda(Do ti spjegojme me vone) 
            //te shumta qe na ndihmojne per llogaritje matematikore
            //Disa nga metodat jane 

            //Fuqia Math.Pow(variabla, fuqia qe po ngrisim)
            double a = Math.Pow(x, 2);
            Console.WriteLine("a "+a);
            
            //Rrenja Katrore Math.Sqrt(variabla)
            double b = Math.Sqrt(a);
            Console.WriteLine("b "+ b);

            //Rrumbullaksimi Math.Round(variabla)
            double c = Math.Round(1.14);
            Console.WriteLine("c " + c);

            //Vlera absolute Math.Abs(variabla)
            double d = Math.Abs(-12);
            Console.WriteLine("d " + d);

            //Rumbullakso Lart Math.Ciel(variabla)
            double e = Math.Ceiling(2.11);
            Console.WriteLine("e " + e);

            //Rrumbullakso Poshte Math.Floor(Variabla)
            double f = Math.Floor(2.99);
            Console.WriteLine("f "+ f);

            //Maximumi Math.Max(var1,var2) Krahason Dy numra
            double g = Math.Max(a,b); 
            Console.WriteLine("g "+ g);

            //Maximumi Math.Min(var1,var2) Krahason Dy numra
            double h = Math.Min(a,b); 
            Console.WriteLine("h " + h);



            Console.ReadKey();
        }
    }
}