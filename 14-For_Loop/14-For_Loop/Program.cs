using System;
using System.Numerics;

namespace _14_For_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //For loop
            // perserit nje kode te caktuar per nje numer te definuar ne program;
            // logjika e njejte me while loop vetem se ne for loop 
            // ne definojme se sa here duhet te perseritet kodi ne baz te tri
            // kushteve  si ne vijim


            // for( int indexi = 0 ; indexi < 10 ; indexi++)
            //kushti 1  >>> deklaro indexin dhe leja vlereen e caktuar
            //              (int indexi = 0)
            //kushti 2  >>> Deklaro kur duhet te perfundoj kushti
            //              (indexi > 10)
            //kishti 3  >>> Rrite indeksin per gjdo iterim te kodid per vleren e caktuar
            //              (indexi++)
           
            for(int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
            }




            while (true)
            {
                Console.Write("Zgjedhe nje numer: ");
                string numriUserit = Console.ReadLine();
                if(numriUserit.Length > 9)
                {
                    Console.WriteLine("Numer shume i madhe. Provo nje numer me te vogel (max 9 shifra).");
                }
                else if (string.IsNullOrWhiteSpace(numriUserit))
                {
                    Console.WriteLine(" Ju lutem shenoni nje numer qe te perfundoj programi.");
                }
                else
                {
                    BigInteger numri = Convert.ToInt64(numriUserit);
                    for (int i = 1; i < numri; i *= 2)
                    {
                        Console.WriteLine(i + "kb");
                    }
                    break;

                }

            }



         
        }
    }
}