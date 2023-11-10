namespace _31_Inhertiance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inhertiance;
            //Trashegimia ne csharp ka te beje me menyren se si
            // ne mund ti trashegojme variabla/metoda  nga nje class
            // parent tek nje class child.


            Car Ford = new Car("Ford",250);
            Bike Suzuki = new Bike("Suzuki",300);
            Boat Yaht = new Boat("Yaht",120);


            //Notice 
            // We are still able to create a Vehicle Class even though 
            // there is no name or speed set for it.
            // WE will learn how to fix this next secion
            //{HINT: ABSTRACTION}
            
            Vehicle veh = new Vehicle();





            Console.WriteLine(Ford.wheels);
            Console.WriteLine(Yaht.wheels);

            Suzuki.go();
            Ford.go();
            Yaht.go();





        }
    }
    class Vehicle
    {
        //Parent Class
        // All Children inherit from me
        public int speed = 0;
        public string name;
  
        public void go()
        {
            Console.WriteLine("{0} is moving {1} m/h.",name,speed);
        }
    
    }
    class Car : Vehicle
    {
        //Child Class
        public int wheels = 4;
        public Car (string name ,int speed)
        {
            this.name = name;
            this.speed = speed;
        }

    }
    class Bike : Vehicle 
    {
        //Child Class
        public int wheels = 2;
        public Bike(string name,int speed)
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