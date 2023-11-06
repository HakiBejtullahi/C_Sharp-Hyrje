namespace _11_SwitchStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Switches
            // alternative ndaj if/else if/else
            // nese keni shume kushte 
            // switches kan sintaks me te shkurte
            // me leht te kuptushme

            // Trego diten

            Console.Write("Sheno diten 1-7: ");
            int dita =  Convert.ToInt32(Console.ReadLine());


            //switches

            switch (dita) { 
                case 1:
                    Console.WriteLine(" E hene");
                    break;
                case 2:
                    Console.WriteLine("E Marte");
                    break;
                case 3:
                    Console.WriteLine("E Merkure");
                    break;
                case 4:
                    Console.WriteLine("E ejte");
                    break;
                case 5:
                    Console.WriteLine("E premte");
                    break;
                case 6:
                    Console.WriteLine("E shtune");
                    break;
                case 7:
                    Console.WriteLine("E dielle");
                    break;
                default :
                    Console.WriteLine("Numer apo tekst i gabuar");
                    break;

            }



            // if  else if else
            //   if (dita == 1)
            //   {
            // Console.WriteLine(" E hene");
            // }
            //else if (dita == 2)
            //{
            //Console.WriteLine("E marte.");
            //}
            //else if (dita == 3)
            //{
            //Console.WriteLine("E Merkure");
            //}
            //else if (dita == 4)
            //{
            //Console.WriteLine("E ejte");
            //}
            //else if (dita == 5)
            //{
            //Console.WriteLine("E premte");
            //}
            //else if (dita == 6) {
            //Console.WriteLine("E shtune");
            //}
            //else if (dita  == 7)
            //{
            //Console.WriteLine(" E dielle");
            //}
            //else
            //{
            //Console.WriteLine("Numer apo tekst i gabuar");
            //}



            Console.ReadKey();
        }
    }
}