namespace _04_Konvertimi_Type_Casting_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Type Casting (Konvertimi) => do te thote qe ne te kthejme nje lloj te
            //dhene ne nje lloj tjeter.

            //Convert.ToString(variabla)


            string age = "23";

            int agenum  = Convert.ToInt32(age);
            Console.WriteLine(agenum + 5);
            
            double ageDec = Convert.ToDouble(age);
            Console.WriteLine(ageDec + 0.5);

            string martuar = "false";

            bool mart = Convert.ToBoolean(martuar);
            //.getType()  per te pare tipin e te dhenave qe nje variabel ka 
            Console.WriteLine(mart.GetType());//do te konvertohet ne bool 

            Console.ReadKey();






        }
    }
}