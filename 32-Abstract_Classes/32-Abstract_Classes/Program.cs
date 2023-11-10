namespace _32_Abstract_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // abstract modifier 
            // modifikim qe mund te vendoset para classes/variables/metodes.
            // ne rastin e class tregon qe eshte incomplete dhe nuk lejon
            // inicializimin.


            Car Ford = new Car("Ford", 250);
            Bike Suzuki = new Bike("Suzuki", 300);
            Boat Yaht = new Boat("Yaht", 120);

            //this can not happen since Vehicle is abstract
            //Vehicle veh = new Vehicle();


            Console.WriteLine(Ford.wheels);
            Console.WriteLine(Yaht.wheels);

            Suzuki.go();
            Ford.go();
            Yaht.go();





        }
    }
    // WE want the Vehicle Class to be abstract
    // because speed =0 and name is uninitialized.
    abstract class Vehicle
    {
        //Parent Class
        // All Children inherit from me
        public int speed = 0;
        public string name;

        public void go()
        {
            Console.WriteLine("{0} is moving {1} m/h.", name, speed);
        }

    }
    class Car : Vehicle
    {
        //Child Class
        public int wheels = 4;
        public Car(string name, int speed)
        {
            this.name = name;
            this.speed = speed;
        }

    }
    class Bike : Vehicle
    {
        //Child Class
        public int wheels = 2;
        public Bike(string name, int speed)
        {
            this.name = name;
            this.speed = speed;
        }
    }
    class Boat : Vehicle
    {
        //Child Class
        public int wheels = 0;
        public Boat(string name, int speed)
        {
            this.name = name;
            this.speed = speed;
        }
    }

}
}