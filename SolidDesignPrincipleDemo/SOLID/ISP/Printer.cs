using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesignPrincipleDemo.SOLID.ISP
{

    public interface IPrinterTasks
    {
        void Print(string PrintContent);
        void Scan(string ScanContent);
        void Fax(string FaxContent);
        void PrintDuplex(string PrintDuplexContent);
    }
    public class LaserJetPrinter : IPrinterTasks
    {
        public void Fax(string FaxContent)
        {
            throw new NotImplementedException();
        }

        public void Print(string PrintContent)
        {
            throw new NotImplementedException();
        }

        public void PrintDuplex(string PrintDuplexContent)
        {
            throw new NotImplementedException();
        }

        public void Scan(string ScanContent)
        {
            throw new NotImplementedException();
        }
    }

    public class LiquidInkjetPrinter : IPrinterTasks
    {
        public void Fax(string FaxContent)
        {
            throw new NotImplementedException();
        }

        public void Print(string PrintContent)
        {
            throw new NotImplementedException();
        }

        public void PrintDuplex(string PrintDuplexContent)
        {
            throw new NotImplementedException();
        }

        public void Scan(string ScanContent)
        {
            throw new NotImplementedException();
        }
    }
}
