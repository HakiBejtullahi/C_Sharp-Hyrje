namespace _23_String_Interpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string interpolation
            // na lejon qe te perdorim variabla brenda stringjeve

            Console.Write("Sheno emrin: ");
            string emri = Console.ReadLine();

            Console.Write("Sheno moshen: ");
            int mosha = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Pershendetje {emri.ToUpper()}, ju jeni {mosha} vjeq.");


            Console.ReadKey();
        }
    }
}