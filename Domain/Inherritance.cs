using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Employee
    {

        string name;
        string gender;
        int age;

        public Employee()
        {

        }

        private void empWork()
        {

        }

    }

    class Manager : Employee
    {
        public Manager()
            : base()
        {

        }

        public void DoManagerWork()
        {

        }

    }

    class Worker : Employee
    {
        public void DoWorkerWork()
        {

        }
    }

    class User
    {
        Worker w = new Worker();

        public void dosome()
        {
            w.DoWorkerWork();


        }
    }
}
