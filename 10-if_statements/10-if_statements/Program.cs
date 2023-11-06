namespace _10_if_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if statements =>  nje forme basike per kontrollimin e programit



            // sintaksa 
            //
            //   if(kushti) {
            //           kodin te cilin duam ta ekzekutojme
            //              } 
            
            
            //kushti patjeter duhet te ktheje true ose false. 


            //if("you are over 18") Kjo nuk funksionon pasi kushti nuk eshte
            //                       i tipit bool


            //else {} nuk ka nevoje per kusht pasi qe vendoset pas kushtit if
            // dhe kodi brenda saj ekzekutohet vetem nese kushti ne if nuk plotoshet

            // else if(kushti) => perdoret per te kontrolluar nese nje kusht tjeter
            //                    plotesohet



            //SHEMBULL: 

            //kerkojme moshen nga useri
            Console.Write("Shenoni moshen tuaj: ");
            int age = Convert.ToInt32(Console.ReadLine());

            //nese mosha eshte me vogel se 18
            if (age <= 18)
            {
                Console.WriteLine(" Ju jeni shume i ri per te hyre.");
            }
            // nese mosha eshte me e madhe ose barabrt me 65
            else if (age >= 65)
            {

                Console.WriteLine("Ju jeni shume i vjeter per te hyre.");
            }
            else if (age > 100) {
                // Duhet te kemi kujdes se si i rendisim kushtet pasi qe nese
                // kushti i pare plotesohet kushtet e tjera nuk do te vlersohen

                // ne kete rast nese useri jep moshen 101
                // kodi ne vijim nuk do te ekzekutohet pasi qe 
                // plotesohet kushti i dyte age >= 65  ==>> 100 >= 65
                // ne kete rast kodi ne vijim nuk do te ekzekutohet asnjehere.
                Console.WriteLine("Ju jeni mbi 100 vjete. ");
            }
            // nese mosha nuk e plotson asnjerin nga kushtet paraprake.
            else
            {
                Console.WriteLine(" Ju mund te hyni.");
            }

        }
    }
}