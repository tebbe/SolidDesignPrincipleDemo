using SolidDesignPrincipleDemo.SOLID.OCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidDesignPrincipleDemo.SOLID.OCP;
using SolidDesignPrincipleDemo.SOLID.LSP;
using SolidDesignPrincipleDemo.SOLID.ISP;

namespace SolidDesignPrincipleDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Validate OCP
            Console.WriteLine("Invoice Amount: 10000");
            Invoices FInvoice = new FinalInvoice();
            double FInvoiceAmount = FInvoice.GetInvoiceDiscount(10000);
            Console.WriteLine($"Final Invoive : {FInvoiceAmount}");
            Invoices PInvoice = new ProposedInvoice();
            double PInvoiceAmount = PInvoice.GetInvoiceDiscount(10000);
            Console.WriteLine($"Proposed Invoive : {PInvoiceAmount}");
            Invoices RInvoice = new RecurringInvoice();
            double RInvoiceAmount = RInvoice.GetInvoiceDiscount(10000);
            Console.WriteLine($"Recurring Invoive : {RInvoiceAmount}");
            //OCP End
            Console.WriteLine("\n**********************************\n");

            //LSP
            //Violate LSP
            AppleLSP appleLSP = new OrangeLSP();
            Console.WriteLine($"Color of Apple: {appleLSP.GetColor()}");

            Console.WriteLine("\n**********************************\n");

            //Validate LSP
            IFruit fruit = new Orange();
            Console.WriteLine($"Color of Orange: {fruit.GetColor()}");
            fruit = new Apple();
            Console.WriteLine($"Color of Apple: {fruit.GetColor()}");
            //LSP End
            Console.WriteLine("\n**********************************\n");


            //Validate ISP
            //Using HPLaserJetPrinter we can access all Printer Services
            HPLaserJetPrinter hPLaserJetPrinter = new HPLaserJetPrinter();
            hPLaserJetPrinter.Print("Printing");
            hPLaserJetPrinter.Scan("Scanning");
            hPLaserJetPrinter.Fax("Faxing");
            hPLaserJetPrinter.PrintDuplex("PrintDuplex");

            Console.WriteLine("\n**********************************\n");
            //Using LiquidInkjetPrinters we can only Access Print and Scan Printer Services
            LiquidInkjetPrinters liquidInkjetPrinter = new LiquidInkjetPrinters();
            liquidInkjetPrinter.Print("Printing");
            liquidInkjetPrinter.Scan("Scanning");
            //ISP End

            Console.ReadKey();
        }
    }
}
