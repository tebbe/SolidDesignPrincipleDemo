using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesignPrincipleDemo.SOLID.OCP
{
    //Validate OCP
    public class Invoices
    {
        public virtual double GetInvoiceDiscount(double amount)
        {
            return amount - 10;
        }
    }

    public class FinalInvoice:Invoices
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount)-60;
        }
    }

    public class ProposedInvoice:Invoices
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount)-40;
        }
    }
    public class RecurringInvoice:Invoices
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount)-20;
        }

    }

    /*
     Tomorrow, if another Invoice Type needs to be added, we need to create a new class 
    by inheriting it from the Invoice class, and if needed, then we need to override 
    the GetInvoiceDiscount() method. The point that you need to keep focus on is we are not 
    changing the code of the Invoice class. Now, the Invoice class is Closed for Modification.
    But it is Open for Extension as it allows the creation of new classes deriving from 
    the base Invoice class, which follows the Open-Closed Principle in C#
     */
}
