namespace _34_Objects_As_Args
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //OBJECTS AS ARGUMENTS


            Car car1 = new Car("Mustang", "red");

            ChangeColor(car1, "green");

            Console.WriteLine("{0} color: {1}",car1.model,car1.color);

            Car car2 = Copy(car1);   




        }

        // obj for method type
        public static Car Copy(Car car)
        {
            return new Car(car.model,car.color);
        }
        
        
        
        
        // obj as param 
        public static void ChangeColor(Car car,string color)
        {
            car.color = color;
        }
    }
}