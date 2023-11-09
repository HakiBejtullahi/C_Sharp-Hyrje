namespace _23_String_Interpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String Interpolation
            // na lejon qe te perdorim variabla brenda stringjeve

            //METODA I


            Console.Write("Sheno emrin: ");
            string emri = Console.ReadLine();

            Console.Write("Sheno moshen: ");
            int mosha = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Pershendetje {emri.ToUpper()}, ju jeni {mosha} vjeq.");


            //METODA II

            //Console
            Console.WriteLine("Hello {0} , You are {1} years old", "petter", 32);

            //String
            string a = "Hello {0}, You are {1} years old";
            Console.WriteLine(a, "John", 32);




            // Format Controll

            //-----------------
            //Numeric Formating
            //-----------------

            // "C" Currency Format
            Console.WriteLine("Price: {0:C}", 23.895);

            // "E" Exponential 
            Console.WriteLine("Fixed Decimal: x{0:F3}", 2.33333);

            // "N" Comma Seperated Large Nums;
            Console.WriteLine("Number: {0:N}", 12222301112);

            // "P"  Percent
            Console.WriteLine("Percent: {0:P}", 0.9999);

            // "X" Hexadecimal
            Console.WriteLine("Hexadecimal: {0:X}", 12354654);


            //-----------------
            //Date Formating
            //-----------------


            // "d" Short date
            Console.WriteLine("Date Short: {0:d}", DateTime.Now);

            // "D" Long Date
            Console.WriteLine("Date Long: {0:D}", DateTime.Now);

            // "t" Short Time
            Console.WriteLine("Time Short: {0:t}", DateTime.Now);

            // "T" Short Time
            Console.WriteLine("Time Short: {0:T}", DateTime.Now);

            // "d" Short Date Custom;
            Console.WriteLine("Custom Date: {0:F}", DateTime.Now.ToString("yyyy/mmm/dd HH:mm:ss tt"));




            Console.ReadKey();
        }
    }
}