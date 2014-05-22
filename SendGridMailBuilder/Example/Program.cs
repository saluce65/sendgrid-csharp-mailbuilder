using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using SendGrid;

namespace Example {
    internal class Program {
        // this code is used for the SMTPAPI examples
        private static void Main() {
            // Create the email object first, then add the properties.
            SendGridMessage myMessage = MailBuilder.Create()
                .To("anna@example.com")
                .From(new MailAddress("john@example.com", "John Smith"))
                .Subject("Testing the SendGrid Library")
                .Text("Hello World!")
                .Build();

            // Create credentials, specifying your user name and password.
            var credentials = new NetworkCredential("username", "password");

            // Create a Web transport for sending email.
            var transportWeb = new Web(credentials);

            // Send the email.
            if (transportWeb != null)
                transportWeb.DeliverAsync(myMessage);

            Console.WriteLine("Done!");
            Console.ReadLine();
        }
    }
}
