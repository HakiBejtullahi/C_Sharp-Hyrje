namespace _21_Exceptions
{
    internal class Program
    {
        static void Main()
        {
            // Exceptions 
            // per menaxhimin e erroreve gjate ekzekutimit

            //try
            //catch
            //finally
            int x, y, result;


            try
            {

                // provo te ekzekutosh kodin


                Console.Write("Sheno numerin e pare: ");
                x= Convert.ToInt32(Console.ReadLine());



                Console.Write("Sheno numerin e dyte: ");
                y = Convert.ToInt32(Console.ReadLine());


                result = x / y;
                Console.WriteLine("result: " + result);

                // nese ka  errore shko te catch(),

                // nese ka finally shko te finally
            }
            catch(FormatException e)
            {
                // pret errorin nese dergojme te dhena qe nuk
                // mund te konvertohen ne int
                // error me formatin e te dhenave
                Console.WriteLine("Enter only numbers please!.");

            }
            catch(DivideByZeroException e)
            {
                // pret errorin nese provojme te pjestojme me 0
                // vlen vetem per int
                Console.WriteLine("Cant divide by 0");
            }
            catch (Exception e)
            {
                // pret te gjitha erroret 
                Console.WriteLine("Something went wrong.");
                
                // shko te finally nese ka
            }
            finally
            {
                // this block runs no matter what
                Console.WriteLine("Doknu apet");
            }

        }
    }
}