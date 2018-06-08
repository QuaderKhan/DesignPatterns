using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class EnumerableVsEnumerator
    {
        private List<int> ages = null;

        public EnumerableVsEnumerator()
        {
            ages = new List<int> {10, 20, 30, 40, 50};
        }

        public void IEnumerableTest()
        {
            var age_IEnumerable = (IEnumerable<int>) ages;
            foreach (int age in age_IEnumerable)
            {
                Console.WriteLine(age);
                if (age > 20)
                {
                    PrinttheNext(age_IEnumerable);
                }
            }
            
        }

        public void IEnumeratorTest()
        {
            IEnumerator<int> age_IEnumerator = ages.GetEnumerator();
            //while (age_IEnumerator.MoveNext())
            //    Console.WriteLine(age_IEnumerator.Current);

            PrintAgeUpto30(age_IEnumerator);
        }


        public void PrintAgeUpto30(IEnumerator<int> age_IEnumerator)
        {
            while (age_IEnumerator.MoveNext())
            {
                Console.WriteLine(age_IEnumerator.Current);
                if (age_IEnumerator.Current > 20)
                {
                    Console.WriteLine("PrintGreaterThan30 is called");
                    PrintGreaterThan30(age_IEnumerator);
                }
            }
        }

        public void PrintGreaterThan30(IEnumerator<int> age_IEnumerator)
        {
            while (age_IEnumerator.MoveNext())
                Console.WriteLine(age_IEnumerator.Current);
        }

        public void PrinttheNext(IEnumerable<int> age_IEnumerable)
        {
            foreach (int age in age_IEnumerable)
            {
                Console.WriteLine(age);
            }
        }

    }
}