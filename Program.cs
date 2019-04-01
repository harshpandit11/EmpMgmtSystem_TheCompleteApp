using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMgmtSystem
{
    public enum EmpDesignations
    {
        AssociateEngineer=1,
        Engineer=2,
        SrEngineer=3,
        EXpertEngineer=4,
        Manager=5,
        Fresher = 6
    }
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public double EmpSalary { get; set; }
        public string EmpAddress { get; set; }
        public string EmpDesignation { get; set; }
        public void GetEmpDesignation(double EmpSal)
        {
            Console.WriteLine("Now let us find out EmpDesignation as per Salary slab");
            Console.ReadLine();
            var empdesgnation1 = EmpDesignations.Fresher;
            var empdesgnation = EmpDesignations.AssociateEngineer;
            var empdesignation5 = EmpDesignations.EXpertEngineer;
            if (EmpSal >= 2000 && EmpSal <= 4000)
            {
                empdesgnation = EmpDesignations.Engineer;
                Console.WriteLine($"The employee's designation is:{empdesgnation}");
            }
            else
            {
                if (EmpSal <= 10)
                {
                    Console.WriteLine("Emp sal cannot be less than 10");
                }
                var empdesgnation2 = EmpDesignations.Fresher;
                Console.WriteLine($"The employee's designation is:{empdesgnation}");
            }
            Console.ReadLine();

        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            var emp = new Employee();
            emp.GetEmpDesignation(1001);

        }
    }
}
