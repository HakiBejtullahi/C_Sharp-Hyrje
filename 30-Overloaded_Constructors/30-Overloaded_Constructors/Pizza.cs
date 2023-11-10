using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Overloaded_Constructors
{
    class Pizza
    {

        bool sosTomatesh = true, djath = true, porshute, suxhuk, kepurdha;
        public Pizza()
        {
            Console.WriteLine("Ingredients: \n{0} \n{1}", Ingredients.sauce, Ingredients.cheese);

        }
        public Pizza(string ing1)
        {
            if (ing1 == Ingredients.dryMeat)
            {
                this.porshute = true;
                Console.WriteLine("Ingredients: \n{0} \n{1} \n{2}\n\n",
                    Ingredients.sauce,
                    Ingredients.cheese,
                    Ingredients.dryMeat);
            }
            else if (ing1 == Ingredients.sausage)
            {
                this.suxhuk = true;
                Console.WriteLine("Ingredients: \n{0} \n{1} \n{2}\n\n",
                    Ingredients.sauce,
                    Ingredients.cheese,
                    Ingredients.sausage);

            }
            else if (ing1 == Ingredients.mushrum)
            {
                this.kepurdha = true;
                Console.WriteLine("Ingredients: \n{0} \n{1} \n{2}\n\n",
                    Ingredients.sauce,
                    Ingredients.cheese,
                    Ingredients.mushrum);
            }
            else
            {
                Console.WriteLine("No such ingredient for pizza!!");
            }
        }
        public Pizza(string ing1, string ing2)
        {
            if (ing1.Equals( Ingredients.dryMeat) && ing2.Equals(Ingredients.sausage))
            {
                this.porshute = true;
                this.suxhuk = true;
                Console.WriteLine("Ingredients: \n{0} \n{1} \n{2} \n{3}\n\n",
                    Ingredients.sauce,
                    Ingredients.cheese,
                    Ingredients.dryMeat,
                    Ingredients.sausage);
            }            
            else if (ing1.Equals( Ingredients.sausage) && ing2.Equals(Ingredients.dryMeat))
            {
                this.porshute = true;
                this.suxhuk = true;
                Console.WriteLine("Ingredients: \n{0} \n{1} \n{2} \n{3}\n\n",
                    Ingredients.sauce,
                    Ingredients.cheese,
                    Ingredients.dryMeat,
                    Ingredients.sausage);
            }
            else if (ing1.Equals(Ingredients.dryMeat) && ing2.Equals(Ingredients.mushrum))
            {
                this.porshute = true;
                this.kepurdha = true;
                Console.WriteLine("Ingredients: \n{0} \n{1} \n{2} \n{3}\n\n",
                    Ingredients.sauce,
                    Ingredients.cheese,
                    Ingredients.sausage,
                    Ingredients.mushrum);

            } 
            else if (ing1.Equals(Ingredients.mushrum) && ing2.Equals(Ingredients.dryMeat))
            {
                this.porshute = true;
                this.kepurdha = true;
                Console.WriteLine("Ingredients: \n{0} \n{1} \n{2} \n{3}\n\n",
                    Ingredients.sauce,
                    Ingredients.cheese,
                    Ingredients.sausage,
                    Ingredients.mushrum);

            }

            else if (ing1.Equals(Ingredients.sausage) && ing2.Equals(Ingredients.mushrum))
            {
                this.suxhuk = true;
                this.kepurdha = true;
                Console.WriteLine("Ingredients: \n{0} \n{1} \n{2} \n{3}\n\n",
                    Ingredients.sauce,
                    Ingredients.cheese,
                    Ingredients.mushrum,
                    Ingredients.sausage);
            }          
            else if (ing1.Equals(Ingredients.mushrum) && ing2.Equals(Ingredients.sausage))
            {
                this.suxhuk = true;
                this.kepurdha = true;
                Console.WriteLine("Ingredients: \n{0} \n{1} \n{2} \n{3} \n\n",
                    Ingredients.sauce,
                    Ingredients.cheese,
                    Ingredients.mushrum,
                    Ingredients.sausage);
            }
            else
            {
                Console.WriteLine("No such ingredient for pizza!!");
            }
        }
        public Pizza(string ing1, string ing2, string ing3)
        {
            this.porshute = true;
            this.kepurdha = true;
            this.suxhuk = true;

            Console.WriteLine("Ingredients: \n{0} \n{1} \n{2} \n{3} \n{4} \n\n",
                   Ingredients.sauce,
                   Ingredients.cheese,
                   Ingredients.mushrum,
                   Ingredients.sausage,
                   Ingredients.dryMeat);
            }





    }
}
