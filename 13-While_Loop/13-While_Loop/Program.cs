using System.Globalization;

namespace _13_While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while loop 
            // Ri egzekuton nje kode deri sa te plotesohet nje kusht i caktuar.

            bool vazhdoWhile = true;


            while (vazhdoWhile)
            {

                Console.Write("Sheno emrin: ");
                string emri  = Console.ReadLine();

                //Ky kode do te ekzekutohet deri sa useri te jep nje 
                // vlere per emrin e cila nuk eshte as vlere e thate as space

                if (string.IsNullOrWhiteSpace(emri))
                {
                    Console.WriteLine("Ju lutem shenoni emrin tuaj");
                }
                else
                {
                    Console.WriteLine("Pershendetje " + emri);

                    //ne kete rast dalim nga loop


                    // nga loop mund te dalim edhe me 

                    //break;
                    
                    
                    vazhdoWhile = false;



                    //KUJDES dalja nga loop eshte shume me rendsi pasi
                    // qe nese nuk dalim nga loop hyjme ne nje infinite loop

                }


            }



        }
    }
}