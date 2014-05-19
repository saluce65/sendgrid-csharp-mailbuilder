#Requirements

This library requires .NET 4.0 and above.

#Installation

To use SendGrid MailBuilder in your C# project, you can either <a href="https://github.com/saluce65/sendgrid-csharp-mailbuilder.git">download the SendGrid MailBuilder C# .NET libraries directly from our Github repository</a> or, if you have the NuGet package manager installed, you can grab them automatically.

```
PM> Install-Package SendGrid-MailBuilder 
```

Once you have the SendGrid MailBuilder libraries properly referenced in your project, you can include calls to them in your code. 
For a sample implementation, check the [Example](https://github.com/saluce65/sendgrid-csharp-mailbuilder/tree/master/SendGrid/Example) folder.

Add the following namespaces to use the library:
```csharp
using System;
using System.Net;
using System.Net.Mail;
using SendGridMail;
```

#How to: Create an email

Use the static *Create* method to create a new **MailBuilder**. Then, fluently call methods to set up the email, including the email sender, the email recipient, the subject, and body of the email.  You can also set up advanced settings for the SMTP API.  Finally, build the **SendGrid** object using the *Build* method.

The following example demonstrates how to create an email object and populate it:

```csharp
// Create the email object first, then add the properties.
SendGrid myMessage = MailBuilder.Create()

    // Add the message properties.
    .From(new MailAddress("john@example.com"))
    
    // Add multiple recipients
    .To(new List<String>
        {
            @"Jeff Smith <jeff@example.com>",
            @"Anna Lidman <anna@example.com>",
            @"Peter Saddow <peter@example.com>"
        })
    
    // Set the subject
    .Subject("Testing the MailBuilder")
    
    // Set the Html and Text versions of the body
    .Html("<p>Hello World!</p>")
    .Text("Hello World plain text!")
    
    // Build the SendGrid object
    .Build();
```

To have the recipients listed as part of the X-SMTPAPI header rather than directly on the email, use the *HideRecipients* method:
```csharp
SendGrid myMessage = MailBuilder.Create()
    .To(new List<String>
        {
            @"Jeff Smith <jeff@example.com>",
            @"Anna Lidman <anna@example.com>",
            @"Peter Saddow <peter@example.com>"
        })
    .From("john@example.com", "John Smith")
    .Subject( "Testing the MailBuilder")
    .Text("Hello You!")
    .HideRecipients()
    .Build();
```

#How to: Add an Attachment

Attachments can be added to a message by calling the *AddAttachment* method and specifying the name and path of the file you want to attach, or by passing a stream. You can include multiple attachments by chaining this method once for each file you wish to attach. The following example demonstrates adding an attachment to a message:

```csharp
SendGrid myMessage = MailBuilder.Create()
    .To("anna@example.com")
    .From("john@example.com", "John Smith")
    .Subject( "Testing the MailBuilder")
    .Text("Hello World!")
    .AddAttachment(@"C:\file1.txt")
    .AddAttachment(new FileStream(@"C:\file.txt", FileMode.Open), "My Cool File.txt")
    .Build();
```

#How to: Use filters to enable footers, tracking, and analytics

SendGrid provides additional email functionality through the use of filters. These are settings that can be added to an email message to enable specific functionality such as click tracking, Google analytics, subscription tracking, and so on. For a full list of filters, see [Filter Settings](http://docs.sendgrid.com/documentation/api/smtp-api/filter-settings/).

Filters can be applied via **MailBuilder** factory methods.

The following examples demonstrate the footer and click tracking filters:

##Footer
```csharp
// Create the email object first, then add the properties.
SendGrid myMessage = MailBuilder.Create()
    .To("anna@example.com")
    .From("john@example.com", "John Smith")
    .Subject( "Testing the MailBuilder")
    .Text("Hello World!")

    // Add a footer to the message.
    .EnableFooter("PLAIN TEXT FOOTER", "<p><em>HTML FOOTER</em></p>")
    .Build()
```

##Click tracking
```csharp
// Create the email object first, then add the properties.
SendGrid myMessage = MailBuilder.Create()
    .To("anna@example.com")
    .From("john@example.com", "John Smith")
    .Subject( "Testing the MailBuilder")
    .Text("Hello World!")
    .Html("<p><a href=\"http://www.example.com\">Hello World Link!</a></p>")
    .Text = "Hello World!"

    // true indicates that links in plain text portions of the email 
    // should also be overwritten for link tracking purposes. 
    .EnableClickTracking(true)
    .Build();
```
[SendGrid Documentation](http://www.sendgrid.com/docs)

This readme adapted from [SendGrid CSharp on GitHub](https://github.com/saluce65/sendgrid-csharp/blob/master/README.md)
