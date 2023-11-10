using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesignPrincipleDemo.SOLID.SRP
{
    //Violate SRP
    public class Invoice
    {

        public long InvoiceAmount { get; set; }
        public DateTime InvoiceDate { get; set; }
        public void AddInvoice()
        {
            try
            {
                // Here we need to write the Code for adding invoice
                // Once the Invoice has been added, then send the  mail
                MailMessage mailMessage = new MailMessage("EMailFrom", "EMailTo", "EMailSubject", "EMailBody");
                this.SendInvoiceEmail(mailMessage);
            }
            catch (Exception ex)
            {
                //Error Logging
                System.IO.File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
            }
        }
        public void DeleteInvoice()
        {
            try
            {
                //Here we need to write the Code for Deleting the already generated invoice
            }
            catch (Exception ex)
            {
                //Error Logging
                System.IO.File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
            }
        }
        public void SendInvoiceEmail(MailMessage mailMessage)
        {
            try
            {
                // Here we need to write the Code for Email setting and sending the invoice mail
            }
            catch (Exception ex)
            {
                //Error Logging
                System.IO.File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
            }
        }

        /*
        As you can see in the above, we create an Invoice class with 
        four functionalities, i.e., 
        Adding and Deleting Invoices, 
        Error Logging, 
        and Sending Emails. 
        As we are putting all the above four functionalities into a single class or module, 
        we are violating the Single Responsibility Principle in C#. 
        This is because Sending Emails and Error Logging is not a part of the Invoice module.
         */
    }
}
