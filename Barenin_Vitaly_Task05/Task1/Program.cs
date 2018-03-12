using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employer employer = new Employer("Vitalya", "Barenin", new DateTime(1997,3,8), 5, "programmer");
            employer.GetInformation(employer);
            Console.ReadLine();
        }
    }
}
