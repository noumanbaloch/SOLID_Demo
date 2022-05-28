using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPDemo.BeforeSRP
{
    public class Employee
    {
        //Responsible Actor - CFO (Chief Financial Officer)
        public decimal CalculatePay()
        {
            RegularHours();
            Console.WriteLine("Calculate pay of employee.");
            return 0;
        }

        //Responsible Actor - COO (Chief Operating Officer)
        public int ReportHours()
        {
            RegularHours();
            Console.WriteLine("Report hours of employee.");
            return 0;
        }

        //Responsible Actor - CTO (Chief Technology Officer)
        public bool Save()
        {
            Console.WriteLine("Save employee data.");
            return true;
        }

        private decimal RegularHours()
        {
            Console.WriteLine("Calculate regular hours of employee.");
            return 0;
        }





    }
}
