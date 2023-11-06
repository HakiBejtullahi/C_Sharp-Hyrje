namespace _19_Method_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // method overloading 
            // metodat kan emer te njejte mirpo parametra te ndryshem;
            // nese duam qe nje metode te funksionoj per nje numer te ndryshem
            // te parametrave mund te perdorim method overloading


            shumzo(2,2);
            shumzo(2,2,2);
            shumzo(2,2,2,2);
            shumzo(2,2,2,2,2);

            
        }

        static double shumzo (double num1,double num2)
        {
            Console.WriteLine(num1 * num2);
            return num1 * num2;
        }
        static double shumzo (double num1,double num2,double num3)
        {
            Console.WriteLine(num1 * num2 * num3);
            return num1 * num2 *num3;
        }
        static double shumzo (double num1,double num2, double num3,double num4)
        {
            Console.WriteLine(num1 * num2 * num3 * num4);
            return num1 * num2*num3*num4;
        }
        static double shumzo (double num1,double num2,double num3,double num4,double num5)
        {
            Console.WriteLine(num1 * num2 * num3 * num4 * num5);
            return num1 * num2*num3 *num4 *num5;
        }
    }
}