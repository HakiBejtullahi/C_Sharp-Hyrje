namespace _09_MetodatPerStringje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Stringjet kan disa metoda specifike te cilat na
            // na ndihmojne qe te manipulojme ose menaxhojme ato.
            // Keto metoda vlejne vetem per stringje

            string fullName = "John Doe";
            string phoneNumber = "123-456-7890";


            // per te pare gjitha metodat qe jane te mundshme per stringjet
            // mjafton qe pas emrit te variables (string) te vendosim (.) dhe
            // pastaj do te shohim te gjitha metodat qe mund te perdorim ne
            // stringje
            // ex fullName.emri_i_metodes





            // Disa nga metodat me te perdorura jane

            // toUpper => shendron te gjitha shkronjat e vogla ne string
            //            ne shkronja te medha
            Console.WriteLine(fullName.ToUpper());



            //toLower => shendron te gjitha shkronjat e medha ne string
            //           ne shkronja te vogla
            Console.WriteLine(fullName.ToLower());



            //Replace() => zevendeson nje karakter me nje tjeter te cilen
            //             e specifikojme ne Replace(a, b)
            //             a =>  karateri te cilin duam ta zevendesojme
            //             b =>  karateri me te cilin duam ta zevendesojme
            Console.WriteLine( phoneNumber.Replace("-", " "));
            // ne rastin konkret po zavendsojme "-" me " " ne stringun
            //phoneNumber



            //Insert() => metoda insert perdoret per te shtuar diqka ne
            //            string duke specifikuar indexin se ku duam te 
            //            shtojme ate. Insert(i,text)
            //            i => indexi ku duam te fillojme
            //            text =>  teksti qe duam te shtojme
            string userName = fullName.Insert(0, "Mr. ");
            Console.WriteLine(userName);





            //length  =>  length nuk eshte metode por property. Nuk ka nevoje
            //            per invoking. Ajo perdoret per te treguar sa karaktera
            //            permban nje string.
            string phoneNumLength = phoneNumber.Replace("-", "");
            Console.WriteLine(phoneNumLength.Length);
            Console.WriteLine(phoneNumber.Length);





            //Indexof() => metode per te gjetur indekxin e nje karakteri ne nje
            //             string te caktuar.
            //             .Indexof(ch)
            //             ch => karakteri qe duam te gjeme
            //             kujdes, kjo do te ktheje vetem indeksin e shfaqjes 
            //             se pare te nje karakteri.

            int iOfN = fullName.IndexOf('n');
            Console.WriteLine(iOfN);


        

            //Substring() => eshte nje metode qe perdoret per te marre vetem
            //               nje pjese te caktuar te nje stringu.
            //               .Substring(i,len)
            //               i =>  indeksi nga ku te fillojme
            //               len =>  sa karaktere te perfshijme
            string firstName = fullName.Substring(0, 4);//fillo me 0 merr 4 karaktere
            string lastName = fullName.Substring(fullName.IndexOf("D"), 3);// fillo me indeksin e J merr 3 karaktere
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            //Per me shume metoda te stringjeve referohu ne internet ose
            // pas vendosjes se pikes pas stringut do te shfaqen te gjitha
            // metodat e mundshme  ne visual studio.


            // Equals() => metode per te kontrollouar nese dy stringje jane te njejta


            Console.WriteLine("firstName = John : "  + firstName.Equals("John"));


            //Compare() =>  Krahason dy stringje sipas renditjes alfabetore te utf8
            //               -1 nese indeksi me i vogel {"abc" para "acc"}
            //               1 nese indeksi me i madh   {"abc" pas "aac"}
            //               0 nese te  barabart {"abc" = "abc"}

            Console.WriteLine("abc".CompareTo("acc"));



            //Contains() => metode qe perdoret per te kontrollouar nese 
            //              nje string permban nje string/char te caktuar.
            //              kthen Bool {True/False}

            string username = "Mr. John Smith";
            Console.WriteLine("UserName Contains 'Mr.': {0}", username.Contains("Mr."));


            //Pad() =>    padding per tekstin; 
            //            PadRight(numriSpace, "symboli")
            //            PadLeft(numriSpace, "symboli")\
            string randomString = "Random String";
            Console.WriteLine("Pad Left: {0}", randomString.PadLeft(30,'.') );
            Console.WriteLine("Pad Right: {0}", randomString.PadRight(30,'.') );


            // Trim()    remove white space
            Console.WriteLine("            Helo world           ");
            Console.Write(">>");
            Console.Write("            Helo world              ".Trim());
            Console.Write("<<");
            Console.ReadKey();
        }
    }
}