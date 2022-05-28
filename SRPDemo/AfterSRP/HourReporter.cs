namespace SRPDemo.AfterSRP
{
    public class HourReporter
    {
        public int ReportHours()
        {
            RegularHours();
            Console.WriteLine("Report hours of employee.");
            return 0;
        }

        private decimal RegularHours()
        {
            Console.WriteLine("Calculate regular hours of employee.");
            return 0;
        }
    }
}