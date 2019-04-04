using System;
using System.Linq;
using ModernCR;

namespace Racers_Unauthorized_Items_Ordered
{
    class Program
    {
        static void Main(string[] args)
        {
            var cr = new RunCrystal();
            cr.BuildReport("D:\\Programs\\Discount Tobacco Center\\Discount Tobacco Center Orders.rpt", "D:\\Programs\\Discount Tobacco Center\\Discount Tobacco Center Orders.pdf");

            cr.SetToAddress("k.mitchell@teammodern.com");
            cr.SetToAddress("krichardson1620@outlook.com");
            cr.SetToAddress("w.silva@teammodern.com");

            cr.SetSubject("Discount Tobacco Center Orders " + DateTime.Now.ToString("MM-dd"));
            cr.SetAttachments("D:\\Programs\\Discount Tobacco Center\\Discount Tobacco Center Orders.pdf");
            cr.SendEmail();
        }
    }
}