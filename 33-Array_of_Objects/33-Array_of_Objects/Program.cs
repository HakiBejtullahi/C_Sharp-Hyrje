namespace _33_Array_of_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array of Objects
            

            //Syntax
            Car[] Cars = new Car[3];




            // Dynamic Setup
            for (int i = 0; i < Cars.Length; i++)
            {
                string model;
                double speed;
               

                while (true)
                {

                Console.Write("Enter Car Model for Car {0}: ",i+1);
                model = Console.ReadLine();

                Console.Write("Enter max speed: ");
                if (!double.TryParse(Console.ReadLine(), out speed)) 
                    {
                        Console.WriteLine("Please enter speed in numbers!");

                    }
                    else 
                    {

                        break;
                    }
                }
                Cars[i] = new Car(model, speed);

            }



            // Invoke Go for each Car in Cars
            Console.WriteLine();
            Console.WriteLine();
            foreach (Car car in Cars)
            {
                car.Go();
            }
            Console.WriteLine();
            Console.WriteLine();
        }

    }
    

}