using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesignPrincipleDemo.SOLID.OCP
{
    //Violate OCP
    public class Invoice
    {
        public double GetInvoiceDiscount(double amount, InvoiceType invoiceType)
        {
            double finalAmount = 0;
            if (invoiceType == InvoiceType.FinalInvoice)
            {
                finalAmount = amount - 100;
            }
            else if (invoiceType == InvoiceType.ProposedInvoice)
            {
                finalAmount = amount - 50;
            }
            return finalAmount;
        }
    }
    public enum InvoiceType
    {
        FinalInvoice,
        ProposedInvoice
    };

    /*
    Please have a look at the above class. As you can see, 
    we have created the GetInvoiceDiscount() method within the Invoice class. 
    As part of that GetInvoiceDiscount() method, we calculate the final amount 
    based on the Invoice type. Currently, we have two Invoice Types, i.e., 
    Final Invoice and Proposed Invoice. So, we have implemented the logic using 
    the if-else condition.

    Tomorrow, if one more Invoice Type comes into the picture, 
    we need to modify the GetInvoiceDiscount() method logic by adding another if block 
    to the source code. Changing the source code for the new requirement violates 
    the Open-Closed Principle.
     */
}
