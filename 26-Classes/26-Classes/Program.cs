using System;

namespace _26_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Messages.Hello();
            Messages.loading();
            Messages.Bye();

            Memos.ShowMemo("Default",21);
           
           
        }
    }

   public static class Memos {


      static  public void ShowMemo(string name,int id)
        {


            Console.WriteLine("Memo Name: {0} \nMemoID: {1}", name,id);
        }
    
    }


}