using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ComparableVsComparer
    {

    }

    public class Employees:IComparable<Employees>
    {
        public string Name { get; set; }
        public int Salary { get; set; }


        #region IComparable<Employee> Members

        public int CompareTo(Employees other)
        {
            if (this.Salary < other.Salary) return 1;
            else if (this.Salary > other.Salary) return -1;
            else return 0;
        }

        #endregion
    }

    public class Employee_SortBySalaryByAscendingOrder : IComparer<Employees>
    {
        #region IComparer<Employees> Members

        public int Compare(Employees x, Employees y)
        {
            if (x.Salary > y.Salary) return 1;
            else if (x.Salary < y.Salary) return -1;
            else return 0;
        }

        #endregion
    }

    public class Employee_SortBySalaryByDescendingOrder : IComparer<Employees>
    {
        #region IComparer<Employee> Members

        public int Compare(Employees x, Employees y)
        {
            if (x.Salary < y.Salary) return 1;
            else if (x.Salary > y.Salary) return -1;
            else return 0;
        }

        #endregion
    }

    public class Employee_SortByName : IComparer<Employees>
    {
        #region IComparer<Employee> Members

        public int Compare(Employees x, Employees y)
        {
            return string.Compare(x.Name, y.Name);
        }

        #endregion
    }
}
