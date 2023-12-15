namespace _18_MethodParmeters
{
    internal class Program
    {

        // Types of parameters/arguments in methods

        static void Main(string[] args)
        {
            int i = 0;
            //Value Parameter: Creates a copy of the argument
            //passed(in this case: copy i to j),so modifications
            //of that parameter (in this case: j =101) in the method
            // do not affect the actual argument passed(in this case: i)
            PassByValueMethod(i);
            Console.WriteLine("i = {0}",i);

            // Reference Parameters: uses the actual parameter passed
            // (in this case: i), and does not create a copy of that argument
            //(in this case: j refers to i and is not a copy of i), so any 
            // modifications made to j  will essentially also affect the argument
            // (in this case:  any change to j will also reflect on i)
            PassByReferenceMethod(ref i);
            Console.WriteLine("i: {0}",i);

            // Out Parameters:  When you want the method to return
            // more than one value.

            int Sum = 0;
            int Product = 0;

            Calculate(10,20,out Sum,out Product);
            Console.WriteLine("Sum: {0}", Sum);
            Console.WriteLine("Product: {0}", Product);



            //Array of Parameters: The params keyword lets us specify a 
            // a method parameter that takes a variable number of arguments
            // You can send a comma-seperated list of arguments, or an array,
            // or no artguments. Params should be the last parameter and can 
            // only be used once in a method. 

            // Note params keyword makes passing arguments at all optional
            // because we do not use the params keyword the method will require
            // at least one argument to be passed
           
            
            //NOTE: this method require a list of parameters or
            //      none at all
            ParamsMethod(1,2,3,4,5,6,7,8,9);
            int[] list = new int[] { 10,20,30,40,50,60,70,80,90};
            ParamsMethod(list);
           
            ParamsMethod();

            //NOTE: this method requires an array as a parameter
            ListMethod(list);


        }
        //Pass by value type of method
        public static void PassByValueMethod( int j)
        {
            j = 101;

        }
        // pass by reference type of method
        public static void PassByReferenceMethod(ref int j)
        {
            j = 101;
        }

        public static void Calculate (int FN, int SN,out int Sum,out int Product)
        {
            Sum = FN + SN;
            Product = FN * SN;
        } 
        public static void ParamsMethod (params int[] Numbers)
        {
            Console.WriteLine("There are {0} elements. They are: ",Numbers.Length);
            foreach(int num in Numbers)
            {
                Console.WriteLine(num);
            }
        }
        public static void ListMethod(int[] numbers)
        {
            Console.WriteLine("There are {0} elements and they are: ",numbers.Length);
            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }
        }

    }
}