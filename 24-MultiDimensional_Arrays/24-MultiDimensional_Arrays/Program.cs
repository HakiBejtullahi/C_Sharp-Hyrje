namespace _24_MultiDimensional_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //array multidimensionale
            // kur kemi disa array brenda nje array.
            
            
            
            
            // Array 2d 
            //deklarimi direkt
            

            String[,] CARS = { { "Mustang", "F-500", "Explorer" },//(0,0) (0,1) (0,2)
                               { "Corvete", "Camaro", "Siverado" },//(1,0) (1,1) (1,2)
                               { "Corrola", "Camry", "Rav4" } };//(2,0) (2,1) (2,2)


            //qasemi me dy indekse  
            //indexi pare =>  dimensioni i pare
            //indexi dyte =>  dimensioni i dyte

            // ne rastin konkret :
            // dimensioni i pare ka 3 arrays
            // dimensioni i dyte ka 3 stringje


            CARS[0, 1] = "F-900";


            // per tu qasur elementeve me foreach

            foreach(string car in CARS)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine();
            
            // me for loop

            for (int i  = CARS.GetLength(0) - 1; i >= 0; i--)// GetLength(dimensioni)
            {
                for (int j = CARS.GetLength(1) - 1 ; j >= 0; j--)
                {
                    Console.WriteLine(CARS[i,j]);
                }
            }


            //Array 3D
            // deklarimi dinamik 


            Console.WriteLine( );
            string[,,] parkingu = new string[3, 3, 2];
            // qasemi me 3 indekse

            
            for(int i = parkingu.GetLength(0) - 1; i >=0; i--)
            {
                for(int j = parkingu.GetLength(1) - 1 ; j >=0; j--)
                {
                    for (int k = parkingu.GetLength(2) - 1 ; k >=0 ; k--)
                    {
                        Console.Write("Hyri vetura rradhes: ");
                        parkingu[i, j, k] = Console.ReadLine();
                    }
                }
            }

            foreach(string car in parkingu)
            {
                Console.WriteLine(car);
            }

            // ... multidimensional array

            Console.ReadKey();
        }
    }
}
