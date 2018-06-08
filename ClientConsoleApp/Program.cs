using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Business;
using FactoryPattern;
using DecoratorPattern.ConcreteComponent;
using DecoratorPattern.Component;
using DecoratorPattern.ConcreteDecorator;

namespace ClientConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Use Factory Pattern
            /*
            Console.WriteLine("Input key type");

            IKey key = KeyFactory.GetKeyByType((KeyTypes)Convert.ToInt16(Console.ReadLine()));

            Console.WriteLine(key.GetKey());
            Console.ReadLine();
            */
            #endregion

            #region Use Decorator Pattern
            /*
            ThickCrust thckCrust = new ThickCrust();
            PrintPizzaCost(thckCrust);

            ThinCrust thnCrust = new ThinCrust();
            PrintPizzaCost(thnCrust);

            Chicken chkn = new Chicken(thckCrust);
            PrintPizzaCost(chkn);

            Mashroom mshrm = new Mashroom(thnCrust);
            PrintPizzaCost(mshrm);

            Paneer pnr = new Paneer(mshrm);
            PrintPizzaCost(pnr);

            Soya soya = new Soya(pnr);
            PrintPizzaCost(soya);

            Console.ReadLine();
            */
            #endregion

            #region Difference between IEnumrable and IEnumrator
            
            EnumerableVsEnumerator e = new EnumerableVsEnumerator();
            //e.IEnumerableTest();//Dont remember the pointer of iteration starts from the first element again.
            //e.IEnumeratorTest(); //Remember the pointer of iteration and starts from the next element where it left.
            //Console.ReadLine();
            
            #endregion

            #region Difference between IComparable and IComparer
            
            // Use Collection Initializers( C# 3.0 ) to initialize the List 
            List<Employees> empList = new List<Employees>() 
		{ new Employees { Name = "a", Salary = 14000 },
                    new Employees { Name = "b", Salary = 13000 } 
                  };

            empList.Sort();
            
            Employee_SortBySalaryByAscendingOrder eAsc =
                    new Employee_SortBySalaryByAscendingOrder();
            // Sort Employees by salary by ascending order.   
            empList.Sort(eAsc);

            Employee_SortBySalaryByDescendingOrder eDsc =
                    new Employee_SortBySalaryByDescendingOrder();
            // Sort Employees by salary by descending order. 
            empList.Sort(eDsc);

            Employee_SortByName eName = new Employee_SortByName();
            // Sort Employees by their names.                                 
            empList.Sort(eName);

             
            #endregion

            #region Equals() and ==
            /*
            //object name = "sandeep";
            //char[] values = { 's', 'a', 'n', 'd', 'e', 'e', 'p' };
            //object myName = new string(values);

            //object myName = "Quader";

            //object myName = "sandeep";

            object name = 2;
            //object myName = 2;
            object myName = name;

            Console.WriteLine("== operator result is {0}", name == myName);
            Console.WriteLine("Equals method result is {0}", myName.Equals(name));
            Console.ReadKey();
            */
            #endregion

            #region Use Extension method

            /*int a = 4;

            Console.WriteLine(a.IncrementByTwo());
            Console.ReadKey();
            */

            #endregion


        }

        #region For Decorator Pattern
        private static void PrintPizzaCost(BasePizza basePizza)
        {
            Console.WriteLine(); // some whitespace for readability
            Console.WriteLine("Item: {0}, Price: {1}", basePizza.name(), basePizza.price());

        }

        #endregion

    }
}
