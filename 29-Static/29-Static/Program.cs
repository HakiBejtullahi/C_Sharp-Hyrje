namespace _29_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //STATIC

            // deklaron nje variabel/metode/class ne forme statike

            //  static {variabel} => variabel qe i perket class-es
            Car car1 = new Car("ford", 256);
            Car car2 = new Car("ferrari", 269);

            Console.WriteLine("Number of cars: {0}",Car.numberOfCars);
            


            //  static {method} => metode qe bene diqka vetem per klasen
            //                     Nuk ka nevoj te inicohet class-a qe te
            //                     thirret metoda. Thirret direkt nga class-a.

            Car.startRace();
            
            if(car1.speed > car2.speed )
            {
                Console.WriteLine("First place: {0}",car1.model);
            }
            else if (car1.speed < car2.speed ) { 
            
                Console.WriteLine("First place: {0}",car2.model);
            }

            //  static {class} => class qe nuk mund te inicializohet
            //                    metodat dhe variablat te gjitha static-e
            //                    perdoret per metoda karakteristika publike
            //                    ku mund te kemi akses nga kudo.

            Math.Round(3.123);
            // Math math1 = new Math()   DOES NOT WORK




        }

    }
    class Car {
        public string model;
        public int speed;
        public static int numberOfCars = 0;




        public Car(string model, int speed)
        {
            this.model = model;
            this.speed = speed;
            numberOfCars++;

        }
        //STATIC
        //=============================================
        public static void startRace() {
            Console.WriteLine("The race has started");

        }
        //=============================================

    }
    



}