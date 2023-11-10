using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesignPrincipleDemo.SOLID.SRP
{
    //Validate SRP

    public interface ILogger
    {
        void Info(string info);
        void Debug(string info);
        void Error(string message, Exception ex);
    }
    public class Logger : ILogger
    {
        public void Debug(string info)
        {
            // here we need to write the Code for Error information into the ErrorLog text file
            throw new NotImplementedException();
        }

        public void Error(string message, Exception ex)
        {
            // here we need to write the Code for Error information into the ErrorLog text file
            throw new NotImplementedException();
        }

        public void Info(string info)
        {
            // here we need to write the Code for Error information into the ErrorLog text file
            throw new NotImplementedException();
        }
    }

    public class MailSender
    {
        public string EMailFrom { get; set; }
        public string EMailTo { get; set; }
        public string EMailSubject { get; set; }
        public string EMailBody { get; set; }
        public void SendEmail()
        {
            // Here we need to write the Code for sending the mail
        }
    }
    public class Invoices
    {
        public long InvAmount { get; set; }
        public DateTime InvDate { get; set; }
        private ILogger fileLogger;
        private MailSender emailSender;
        public Invoices()
        {
            fileLogger = new Logger();
            emailSender = new MailSender();
        }
        public void AddInvoice()
        {
            try
            {
                fileLogger.Info("Add method Start");
                // Here we need to write the Code for adding invoice
                // Once the Invoice has been added, then send the  mail
                emailSender.EMailFrom = "emailfrom@xyz.com";
                emailSender.EMailTo = "emailto@xyz.com";
                emailSender.EMailSubject = "Single Responsibility Princile";
                emailSender.EMailBody = "A class should have only one reason to change";
                emailSender.SendEmail();
            }
            catch (Exception ex)
            {
                fileLogger.Error("Error Occurred while Generating Invoice", ex);
            }
        }
        public void DeleteInvoice()
        {
            try
            {
                //Here we need to write the Code for Deleting the already generated invoice
                fileLogger.Info("Delete Invoice Start at @" + DateTime.Now);
            }
            catch (Exception ex)
            {
                fileLogger.Error("Error Occurred while Deleting Invoice", ex);
            }
        }
    }
    /*
    As shown in the above, we create three classes. In the invoice class, 
    only invoice-related functionalities are going to be implemented. 
    The Logger class is going to be used only for logging purposes. 
    Similarly, the Email class is going to handle Email activities. 
    Now, each class has only its own responsibilities. 
    As a result, it follows the Single Responsibility Principle in C#. 
    If you want to modify the email functionality, you must change the Email class only, 
    not the Invoice and Logging class. 
    Similarly, if you want to modify the Invoice functionalities, you must change the Invoice class only, 
    not the Email and Logging class
     */
}
