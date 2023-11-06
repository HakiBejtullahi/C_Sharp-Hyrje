namespace _16_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arrays
            // nje variable e cila mund te ruaj me shume se nje te dhene
            // mund te konsiderohet si nje form e listes

            //Sintaksa: 

            // DataType [] emriListes = {element,element,element}




             String[] cars = { "BMW", "VW", "Mercedes", "Toyota", "Ford" };

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            // Array ka nje madhesi te caktuar. Ne nuk mund
            // tu qasemi elementeve te cilat nuk egzistojn 
            //cars[10];   kjo kthen error  spese cars ka vetem 5
            //            elemente dhe i fundit ka indeksin 4


            Console.WriteLine();
            // nese duam ta ndryshojm nje element brenda array

            cars[1] = "Audi";
            Console.WriteLine(cars[1]);

            // nese nuk duam ti deklarojme elementet direkt
            // ne mund te krijojme nje array empty
            // mripo madhesia e array duhet te caktohet

            string[] ListaKerreve = new string[5];
            

            for (int i = 0; i < ListaKerreve.Length; i++)
            {
                Console.Write("sheno nje brand te kerreve: ");
                ListaKerreve[i] = Console.ReadLine();
            }

            Console.WriteLine(ListaKerreve[0]);
        }
    }
}