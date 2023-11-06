namespace _02_Variablat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // deklarimi i variablave
            string emri;

            // inicializimi i variablave
            emri = "John";

            //deklarimi dhe inicializimi 
            string mbiemri = "Doe";

            //Variablat jane si lloj kuti ku ne mund te ruajm te
            //dhenat qe mund te na nevojiten ne aplikacion.Normalisht per te pasur
            //me te lehte per te menaxhuar keto kuti ne vendosim atribute(shenja)
            //neper to.

            //se pari llojin e te dhenave (psh string), ku ne te tije ne mund
            // te klasifikojme qfare lloj i te dhene eshte (numer(int), shkronja(String) etj) (Obligative)

            // se dyti nje emer te cilit mund ti adresohemi me vone per tu qasur ne
            //informacionin qe variabla posedon.(ne rastin konkret emri eshte mbiemri kurse informacioni "Dio")
            //kujdes emri duhet te jete unik brenda nje skopi { brenda kllapave }.


            //Disa nga llojet me te perdorura te tipit te te dhenave primitive jane:

            //string => tekst
            // string emri => kthen error sepse emri eshte deklaru ma lart.
            string emriPlote = "John Doe";

            //int => numer i plote
            int mosha = 23;

            //double => numer decimal
            double gjatsia = 1.68;

            //bool => true/false
            bool martuar = false;

            //char => simbol
            char a = 'B';

            //
            //
            //bashkimi i variablave
            //
            //

            //string + string
            Console.WriteLine( "Hello " + emriPlote);

            // string + int
            Console.WriteLine(emriPlote + " ka moshen " + mosha);
            //mosha kthehet ne string

            //string + bool
            Console.WriteLine("i martuar "+ martuar);
            //bool kthehet ne string







            Console.ReadKey();
        }
    }
}