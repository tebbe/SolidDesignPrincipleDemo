using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesignPrincipleDemo.SOLID.ISP
{

    public interface IPrintersTasks
    {
        void Print(string printContent);
        void Scan(string scanContent);
    }

    interface IFaxTasks
    {
        void Fax(string content);
    }
    interface IPrintDuplexTasks
    {
        void PrintDuplex(string content);
    }

    public class HPLaserJetPrinter : IPrintersTasks, IFaxTasks, IPrintDuplexTasks
    {
        public void Fax(string content)
        {
            //code
            Console.WriteLine(content);
        }

        public void Print(string printContent)
        {
            //code
            Console.WriteLine(printContent);
        }

        public void PrintDuplex(string content)
        {
            //code
            Console.WriteLine(content);
        }

        public void Scan(string scanContent)
        {
            //code
            Console.WriteLine(scanContent);
        }
    }

    public class LiquidInkjetPrinters : IPrintersTasks
    {
        public void Print(string printContent)
        {
            //code
            Console.WriteLine(printContent);
        }

        public void Scan(string scanContent)
        {
            //code
            Console.WriteLine(scanContent);
        }
    }
}
