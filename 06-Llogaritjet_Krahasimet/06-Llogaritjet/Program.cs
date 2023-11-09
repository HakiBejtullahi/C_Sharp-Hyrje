namespace _06_Llogaritjet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "LLogaritjet");
            Console.WriteLine( "--------------");
            // LLOGARITJET

            int friends = 5;
            Console.Write("vlera fillestare: ");
            Console.WriteLine(friends);
            //increment-rritje per nje apo me shume

            //Keto metoda funksionojn edhe per shumzim pjestim modulo(mbetja)

            //metoda gjate
            friends = friends + 2;// beje kalkulimet si matematike
            //metoda mesatare
            friends += 7;//rrite per vleren pas barazimit
            //metoda shkurte
            friends++; // rrite vetem per nje

            Console.Write("vlera pas rritjes(increment): ");
            Console.WriteLine(friends);

            //decrement - zbritje per nje apo me shume

            //metoda gjate
            friends = friends - 2;// beje kalkulimet si matematike
            //metoda mesatare
            friends -= 7;//zbrite per vleren pas barazimit
            //metoda shkurte
            friends--; // zbrite vetem per nje


            Console.Write("vlera pas zbritjes(decrement): ");
            Console.WriteLine(friends);


            int num1, num2, num3, num4, num5;

            num1 = 3;
            num2 = 4;
            num3 = 6;
            num4 = 10;
            num5 = 11;

            //Mledhja
            int Shuma = num4 + num5;//21
            Console.WriteLine("shume " + Shuma);
            //Zbritja
            int zbritja = num1 - num4;//-7
            Console.WriteLine("zbritja " + zbritja);
            //Shumzimi
            int shumzimi = num1  * num2; // 12
            Console.WriteLine("shumzimi " + shumzimi);
            //Pjestimi
            //kujdes shiko rezultatin
            int pjestimi = num4 / num1;
            Console.WriteLine( "pjestimi pa mbjetje " +  pjestimi);
            //Mbetja
            int mbetja = num4 % num1;
            Console.WriteLine("mbetja " + mbetja);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Krahasimet");
            Console.WriteLine( "--------------");
            
            //KRAHASIMET

            // krahasimet ne csharp behen ne kete menyre

            // ==   nese vlerat jane te barabarta 
            //      kthejn form bool true ose false
            //      kujdes nuk funksionon per stringje
            Console.WriteLine();
            Console.WriteLine("10 == 20 : " + (10 == 20));
            Console.WriteLine("20 == 20 : " + (20 == 20));
            Console.WriteLine("stringA == stringA : " +("stringA" == "stringA"));
            Console.WriteLine("a == b : " + ('a' == 'b'));

            // !=  nese vlerat NUK jane te barabarta
            //     ! =>  ka kuptimin e negacionit (e kunderta)
            Console.WriteLine();
            Console.WriteLine("10 != 20 : " + (10 != 20));
            Console.WriteLine("20 != 20 : " + (20 != 20));
            Console.WriteLine("stringA != stringA : " + ("stringA" != "stringA"));
            Console.WriteLine("a != b : " + ('a' != 'b'));

            // > , >= , < , <=  nese vlerat jane me e madhe/barabart ose me e
            //                  me e vogel/barabart respektivisht.

            Console.WriteLine();
            Console.WriteLine("10 > 20 : " + (10 > 20));
            Console.WriteLine("20 >= 20 : " + (20 >= 20));
            Console.WriteLine("10 < 20 : " + (10 < 20));
            Console.WriteLine("20 <= 20 : " + (20 <= 20));
            //KUJDES - Te char llogariten sipas indeksit te renditjes 
            //         se shkronjes se pare, duke filluar nga shkronja
            //         A - Z, a-z.
            //KUJDES - Kjo metode nuk perdoret per stringje.
            
            Console.WriteLine("A < a : " + ('A' < 'a'));
            Console.WriteLine("A == a : " + ('A' == 'a'));
            Console.WriteLine("a < b : " + ('a' < 'b'));

            Console.WriteLine();


            Console.ReadKey();  
        }
    }
}