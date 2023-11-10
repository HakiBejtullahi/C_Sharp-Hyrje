namespace _35_Method_Overriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Method Overriding
            // provides a new version of a method inherited from a parent
            // class. The parent method must be :
            // abstract, virtual or already overriden
            // used with ToString(), polymorphism


            Dog dog = new Dog();
            Cat cat = new Cat();    

            dog.speak();
            cat.speak();
            
            Console.ReadKey();
        }
    }
}
