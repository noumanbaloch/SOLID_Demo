using SRPDemo.AfterSRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPDemo.AfterSRP
{
    public class Employee
    {
        public void Main()
        {
            var payCalculator = new PayCalculator();
            payCalculator.CalculatePay();

            var hourReporter = new HourReporter();
            hourReporter.ReportHours();

            var employeeSaver = new EmployeeSaver();
            employeeSaver.Save();
        }
    }
}
