using System.Collections.Generic;

namespace _36_Delegatees
{


    internal class Program
    {
        //Delegates and their ussage

        static void Main(string[] args)
        {
            List <Employee> employees = new List<Employee> {

             new  Employee(101,"mike",4999.99,4),
             new  Employee(102,"petter",2599.99,2),
             new  Employee(103,"anna",4599.99,3),
             new  Employee(104,"john",999.99,1),
             new  Employee(105,"susy",3999.99,3),
            
            };


            //create an instance of the delegate in where we need it 
            // we pass as argument the method we wrote PromoteEmployeeByExp to the delegate since this is the method we want it to point to this time
            // since we get the emplyee object 
            PromoteEmployeeDelegate isPromotable = new PromoteEmployeeDelegate(PromoteEmployeeByExp);

            //We invoke the Employee class method for PromoteEmployee and we pas the list and delegate as the arguments.
            Employee.PromoteEmployee(employees,isPromotable);

            //If we want to create a different filtering logic where we check by how much they are being paid, we simply
            //need to create a different method and make the delegate point to new method. 


        }



    //define a method to filter employees by their exp as requested by delegate.
    public static bool PromoteEmployeeByExp (Employee employee)
    {
        if(employee.Experience > 3)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    }


    //Invoking a Delegate (similar to methods onlye keyword delegate)
    //It requirees an implementation of the method by using original methods but with the same face as delegate.

    //=======================================================
    delegate bool PromoteEmployeeDelegate(Employee empl);
    //=======================================================

    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }  
        public int Experience { get; set; } 



        public Employee(int id,string name,double salary,int experience) {
            this.ID = id;
            this.Name = name;   
            this.Salary = salary;
            this.Experience = experience;
        }
        



        //We get the filtering logic for this method in class Employee by requireing a
        //second argument to the method which is a delegate of type bool in this case
        //since we need to check if else statements
               
        public static void PromoteEmployee (List<Employee> employeeList,PromoteEmployeeDelegate IsPromotableBool)
        {
            foreach(Employee employee in employeeList)
            {
                //we invoke IsPromotableBool or in this case PromoteEmployeeDelegate and we pass the employee instance to the method. We get the delegate as an argument.
                //Since Delegates point to a method, this case our method PromoteEmployeeByExp, we check for the employee obj if it meets the requirements to
                // be selected by promotion,and then return e bool value true false respectively wether the requirement has been fulfilled acording to this method.
                if(IsPromotableBool(employee))
                {
                    String employeeName = employee.Name.ToString();
                    employeeName = employeeName.Substring(0,1).ToUpper() + employeeName.Substring(1);

                    
                    Console.WriteLine(employeeName + ", is up for promotion.");
                }
            }
        }
    }

}