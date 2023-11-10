namespace _27_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //                   Objects (Objektet)

            // Nje instance e nje class-e
            // Nese Class-a llogaritet si plani i shtepise
            // Objekti mund te llogaritet si shtepia e ndertuar

            //   Objektet kan variabla dhe metoda (funksione)
            //                {karakteristika;veprimet} 





            //Syntax

            // Inicializimi i nje objekti
            Human human1 = new Human();

            // Aksesi ne karakteristika per shkak public
            // NOTE: kjo metode nuk rekomandohet 
            human1.name = "Rick"; ;
            human1.age = 56;
            

            // ne mund te krijojme sa te duam objekte
            Human human2 = new Human();
            human2.name = "Morty"; ;
            human2.age = 16;


            // Aksesi ne metoda per shkak public
            human1.eat();
            human2.eat();
            human1.sleep();
            human2.sleep();



        }
    }
    public class Human {
        public string name;
        public int age;


        public void eat()
        {
            Console.WriteLine("{0} is eating...",name);
        }
        public void sleep()
        {
            Console.WriteLine("{0} is sleeping...",name);
        }


        }
}