namespace _22_Conditional_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // conditional operator
            //perdoret si if dhe else nese kemi sintaks te shkurte.



            // (kushti) ? nese true return kete : nese jo return kete

            double temp = 20;
            string messazhi;

            //if(temp >= 15)
            //{
            //    messazhi = "eshte ngrohte jashte";
            //}
            //else
            //{
            //    messazhi = "eshte ftoft jashte";
            //}

            messazhi = temp >= 20 ? "eshte ngrohte jashte" : "eshte ftoft jashte";


            Console.WriteLine(messazhi);



        }
    }
}