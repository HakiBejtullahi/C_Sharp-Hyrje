namespace _28_Konstruktoret
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //                        Konstruktori 



            //  nje metode e cila sherben per krijimin e nje objekti
            //  duhet te kete emrin e njejte si class-a


            //Konstruktori - Perdorimi
            //===================================
            Human human1 = new Human("Rick",43);
            Human human2 = new Human("Morty",23);
            Human human3 = new Human("Bob", 32);
            //===================================

            human2.GetName();
            human1.GetAge();
            human3.GetName();

        }

    }
    class Human {

        string name;
        int age;

        //Konstruktori -Krijimi
        //========================================
        public Human(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        //========================================

        public void GetAge()
        {
            Console.WriteLine("{0} is {1} years old",name,age);
        }
        public void GetName()
        {
            Console.WriteLine("Hi I am {0}.",name);
        }
    
    
    }

}