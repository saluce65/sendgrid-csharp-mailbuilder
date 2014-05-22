using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SendGrid;
using System.Collections.Generic;
using System.Net.Mail;
using System.Linq;
using System.IO;

namespace SendGridMailBuilder.Tests {
    [TestClass]
    public class UnitTest1 {
        private MailBuilder BasicMailBuilder {
            get {
                return MailBuilder.Create()
                    .To("jack@example.com")
                    .From("jill@example.com")
                    .Subject("Broken Crown")
                    .Text("Are you ok after falling down that hill?  -Love, Jill");
            }
        }
        private MailBuilder BasicMailBuilder_NoTo {
            get {
                return MailBuilder.Create()
                    .From("jill@example.com")
                    .Subject("Broken Crown")
                    .Text("Are you ok after falling down that hill?  -Love, Jill");
            }
        }
        private MailBuilder BasicMailBuilder_NoFrom {
            get {
                return MailBuilder.Create()
                    .To("jack@example.com")
                    .Subject("Broken Crown")
                    .Text("Are you ok after falling down that hill?  -Love, Jill");
            }
        }
        private MailBuilder BasicMailBuilder_NoSubject {
            get {
                return MailBuilder.Create()
                    .To("jack@example.com")
                    .From("jill@example.com")
                    .Text("Are you ok after falling down that hill?  -Love, Jill");
            }
        }
        private MailBuilder BasicMailBuilder_NoText {
            get {
                return MailBuilder.Create()
                    .To("jack@example.com")
                    .From("jill@example.com")
                    .Subject("Broken Crown");
            }
        }

        #region App Disable Methods
        [TestMethod]
        public void Test_DisablingBcc() {
            var mail = BasicMailBuilder
                .DisableBcc()
                .Build();

            var message = new SendGridMessage();
            message.DisableBcc();
            Assert.IsFalse(string.IsNullOrEmpty(message.Header.JsonString()));
            Assert.AreEqual(message.Header.JsonString(), mail.Header.JsonString());
        }
        [TestMethod]
        public void Test_DisablingBypassListManagement() {
            var mail = BasicMailBuilder
                .DisableBypassListManagement()
                .Build();

            var message = new SendGridMessage();
            message.DisableBypassListManagement();
            Assert.IsFalse(string.IsNullOrEmpty(message.Header.JsonString()));
            Assert.AreEqual(message.Header.JsonString(), mail.Header.JsonString());
        }
        [TestMethod]
        public void Test_DisablingClickTracking() {
            var mail = BasicMailBuilder
                .DisableClickTracking()
                .Build();

            var message = new SendGridMessage();
            message.DisableClickTracking();
            Assert.IsFalse(string.IsNullOrEmpty(message.Header.JsonString()));
            Assert.AreEqual(message.Header.JsonString(), mail.Header.JsonString());
        }
        [TestMethod]
        public void Test_DisablingFooter() {
            var mail = BasicMailBuilder
                .DisableFooter()
                .Build();

            var message = new SendGridMessage();
            message.DisableFooter();
            Assert.IsFalse(string.IsNullOrEmpty(message.Header.JsonString()));
            Assert.AreEqual(message.Header.JsonString(), mail.Header.JsonString());
        }
        [TestMethod]
        public void Test_DisablingGoogleAnalytics() {
            var mail = BasicMailBuilder
                .DisableGoogleAnalytics()
                .Build();

            var message = new SendGridMessage();
            message.DisableGoogleAnalytics();
            Assert.IsFalse(string.IsNullOrEmpty(message.Header.JsonString()));
            Assert.AreEqual(message.Header.JsonString(), mail.Header.JsonString());
        }
        [TestMethod]
        public void Test_DisablingGravatar() {
            var mail = BasicMailBuilder
                .DisableGravatar()
                .Build();

            var message = new SendGridMessage();
            message.DisableGravatar();
            Assert.IsFalse(string.IsNullOrEmpty(message.Header.JsonString()));
            Assert.AreEqual(message.Header.JsonString(), mail.Header.JsonString());
        }
        [TestMethod]
        public void Test_DisablingOpenTracking() {
            var mail = BasicMailBuilder
                .DisableOpenTracking()
                .Build();

            var message = new SendGridMessage();
            message.DisableOpenTracking();
            Assert.IsFalse(string.IsNullOrEmpty(message.Header.JsonString()));
            Assert.AreEqual(message.Header.JsonString(), mail.Header.JsonString());
        }
        [TestMethod]
        public void Test_DisablingSpamCheck() {
            var mail = BasicMailBuilder
                .DisableSpamCheck()
                .Build();

            var message = new SendGridMessage();
            message.DisableSpamCheck();
            Assert.IsFalse(string.IsNullOrEmpty(message.Header.JsonString()));
            Assert.AreEqual(message.Header.JsonString(), mail.Header.JsonString());
        }
        [TestMethod]
        public void Test_DisablingTemplate() {
            var mail = BasicMailBuilder
                .DisableTemplate()
                .Build();

            var message = new SendGridMessage();
            message.DisableTemplate();
            Assert.IsFalse(string.IsNullOrEmpty(message.Header.JsonString()));
            Assert.AreEqual(message.Header.JsonString(), mail.Header.JsonString());
        }
        [TestMethod]
        public void Test_DisablingUnsubscribe() {
            var mail = BasicMailBuilder
                .DisableUnsubscribe()
                .Build();

            var message = new SendGridMessage();
            message.DisableUnsubscribe();
            Assert.IsFalse(string.IsNullOrEmpty(message.Header.JsonString()));
            Assert.AreEqual(message.Header.JsonString(), mail.Header.JsonString());
        }
        #endregion

        #region App Enable Methods
        [TestMethod]
        public void Test_EnablingBcc() {
            var mail = BasicMailBuilder
             .EnableBcc("bcc@example.com")
             .Build();

            var message = new SendGridMessage();
            message.EnableBcc("bcc@example.com");
            Assert.IsFalse(string.IsNullOrEmpty(message.Header.JsonString()));
            Assert.AreEqual(message.Header.JsonString(), mail.Header.JsonString());
        }
        [TestMethod]
        public void Test_EnablingBypassListManagement() {
            var mail = BasicMailBuilder
                .EnableBypassListManagement()
                .Build();

            var message = new SendGridMessage();
            message.EnableBypassListManagement();
            Assert.IsFalse(string.IsNullOrEmpty(message.Header.JsonString()));
            Assert.AreEqual(message.Header.JsonString(), mail.Header.JsonString());
        }
        [TestMethod]
        public void Test_EnablingClickTracking() {
            var mail = BasicMailBuilder
                .EnableClickTracking()
                .Build();

            var message = new SendGridMessage();
            message.EnableClickTracking();
            Assert.IsFalse(string.IsNullOrEmpty(message.Header.JsonString()));
            Assert.AreEqual(message.Header.JsonString(), mail.Header.JsonString());
        }
        [TestMethod]
        public void Test_EnablingClickTracking_false() {
            var mail = BasicMailBuilder
                .EnableClickTracking(false)
                .Build();

            var message = new SendGridMessage();
            message.EnableClickTracking(false);
            Assert.IsFalse(string.IsNullOrEmpty(message.Header.JsonString()));
            Assert.AreEqual(message.Header.JsonString(), mail.Header.JsonString());
        }
        [TestMethod]
        public void Test_EnablingClickTracking_true() {
            var mail = BasicMailBuilder
                .EnableClickTracking(true)
                .Build();

            var message = new SendGridMessage();
            message.EnableClickTracking(true);
            Assert.IsFalse(string.IsNullOrEmpty(message.Header.JsonString()));
            Assert.AreEqual(message.Header.JsonString(), mail.Header.JsonString());
        }
        [TestMethod]
        public void Test_EnablingFooter() {
            var mail = BasicMailBuilder
                .EnableFooter()
                .Build();

            var message = new SendGridMessage();
            message.EnableFooter();
            Assert.IsFalse(string.IsNullOrEmpty(message.Header.JsonString()));
            Assert.AreEqual(message.Header.JsonString(), mail.Header.JsonString());
        }
        [TestMethod]
        public void Test_EnablingFooter_text_html() {
            var mail = BasicMailBuilder
                .EnableFooter(text: "text", html: "html")
                .Build();

            var message = new SendGridMessage();
            message.EnableFooter(text: "text", html: "html");
            Assert.IsFalse(string.IsNullOrEmpty(message.Header.JsonString()));
            Assert.AreEqual(message.Header.JsonString(), mail.Header.JsonString());
        }
        [TestMethod]
        public void Test_EnablingGoogleAnalytics() {
            var mail = BasicMailBuilder
                .EnableGoogleAnalytics("source", "medium", "term", content: "content", campaign: "campaign")
                .Build();

            var message = new SendGridMessage();
            message.EnableGoogleAnalytics("source", "medium", "term", content: "content", campaign: "campaign");
            Assert.IsFalse(string.IsNullOrEmpty(message.Header.JsonString()));
            Assert.AreEqual(message.Header.JsonString(), mail.Header.JsonString());
        }
        [TestMethod]
        public void Test_EnablingGravatar() {
            var mail = BasicMailBuilder
                .EnableGravatar()
                .Build();

            var message = new SendGridMessage();
            message.EnableGravatar();
            Assert.IsFalse(string.IsNullOrEmpty(message.Header.JsonString()));
            Assert.AreEqual(message.Header.JsonString(), mail.Header.JsonString());
        }
        [TestMethod]
        public void Test_EnablingOpenTracking() {
            var mail = BasicMailBuilder
                .EnableOpenTracking()
                .Build();

            var message = new SendGridMessage();
            message.EnableOpenTracking();
            Assert.IsFalse(string.IsNullOrEmpty(message.Header.JsonString()));
            Assert.AreEqual(message.Header.JsonString(), mail.Header.JsonString());
        }
        [TestMethod]
        public void Test_EnablingSpamCheck() {
            var mail = BasicMailBuilder
                .EnableSpamCheck()
                .Build();

            var message = new SendGridMessage();
            message.EnableSpamCheck();
            Assert.IsFalse(string.IsNullOrEmpty(message.Header.JsonString()));
            Assert.AreEqual(message.Header.JsonString(), mail.Header.JsonString());
        }
        [TestMethod]
        public void Test_EnablingSpamCheck_2_url() {
            var mail = BasicMailBuilder
                .EnableSpamCheck(score: 2, url: "http://spamcheck.example.com")
                .Build();

            var message = new SendGridMessage();
            message.EnableSpamCheck(score: 2, url: "http://spamcheck.example.com");
            Assert.IsFalse(string.IsNullOrEmpty(message.Header.JsonString()));
            Assert.AreEqual(message.Header.JsonString(), mail.Header.JsonString());
        }
        [TestMethod]
        public void Test_EnablingTemplate() {
            var mail = BasicMailBuilder
                .EnableTemplate("<% BODY %>")
                .Build();

            var message = new SendGridMessage();
            message.EnableTemplate("<% BODY %>");
            Assert.IsFalse(string.IsNullOrEmpty(message.Header.JsonString()));
            Assert.AreEqual(message.Header.JsonString(), mail.Header.JsonString());
        }
        [TestMethod]
        public void Test_EnablingUnsubscribe_replace() {
            var mail = BasicMailBuilder
                .EnableUnsubscribe("replace")
                .Build();

            var message = new SendGridMessage();
            message.EnableUnsubscribe("replace");
            Assert.IsFalse(string.IsNullOrEmpty(message.Header.JsonString()));
            Assert.AreEqual(message.Header.JsonString(), mail.Header.JsonString());
        }
        #endregion

        // There seems to be some issue with SendGrid.EnableUnsubscribe.  
        // Need to investigate that issue before enabling this test.
        //[TestMethod]
        public void Test_EnablingUnsubscribe_text_html() {
            var mail = BasicMailBuilder
                .EnableUnsubscribe(
                    "If you would like to unsubscribe and stop receiving these emails <% click here %>.",
                    "If you would like to unsubscribe and stop receiving these emails click here: <% %>.")
                .Build();

            var message = new SendGridMessage();
            message.EnableUnsubscribe(
                "If you would like to unsubscribe and stop receiving these emails <% click here %>.",
                "If you would like to unsubscribe and stop receiving these emails click here: <% %>.");
            Assert.IsFalse(string.IsNullOrEmpty(message.Header.JsonString()));
            Assert.AreEqual(message.Header.JsonString(), mail.Header.JsonString());
        }

        #region Header Methods
        [TestMethod]
        public void Test_AddHeader() {
            var mail = BasicMailBuilder
                .AddHeader("X-TEST", "MAILBUILDER")
                .Build();

            var message = new SendGridMessage();
            message.Headers.Add("X-TEST", "MAILBUILDER");
            Assert.IsTrue(mail.Headers.All(e => message.Headers.Contains(e)));
        }
        [TestMethod]
        public void Test_AddHeaders() {
            var mail = BasicMailBuilder
                .AddHeaders(new Dictionary<string, string>() {
                    { "X-TEST", "MAILBUILDER" },
                    { "X-TEST-2", "SENDGRID" }
                })
                .Build();

            var message = new SendGridMessage();
            message.Headers.Add("X-TEST", "MAILBUILDER");
            message.Headers.Add("X-TEST-2", "SENDGRID");
            Assert.IsTrue(mail.Headers.All(e => message.Headers.Contains(e)));
        }
        [TestMethod]
        public void Test_Substitute() {
            var tag = "{this}";
            var replacements = new List<string>() { "that", "that other", "and one other" };
            var mail = BasicMailBuilder
                .Substitute(tag, replacements)
                .Build();

            var message = new SendGridMessage();
            message.AddSubstitution(tag, replacements);
            Assert.IsFalse(string.IsNullOrEmpty(message.Header.JsonString()));
            Assert.AreEqual(message.Header.JsonString(), mail.Header.JsonString());
        }
        [TestMethod]
        public void Test_SetCategory() {
            var category = "test";
            var mail = BasicMailBuilder
                .SetCategory(category)
                .Build();

            var message = new SendGridMessage();

            message.SetCategory(category);
            Assert.IsFalse(string.IsNullOrEmpty(message.Header.JsonString()));
            Assert.AreEqual(message.Header.JsonString(), mail.Header.JsonString());
        }
        [TestMethod]
        public void Test_SetCategories() {
            var categories = new List<string>() { "test", "email" };
            var mail = BasicMailBuilder
                .SetCategories(categories)
                .Build();

            var message = new SendGridMessage();

            message.SetCategories(categories);
            Assert.IsFalse(string.IsNullOrEmpty(message.Header.JsonString()));
            Assert.AreEqual(message.Header.JsonString(), mail.Header.JsonString());
        }
        [TestMethod]
        public void Test_IncludeUniqueArg() {
            var mail = BasicMailBuilder
                .IncludeUniqueArg("key", "value")
                .Build();

            var message = new SendGridMessage();

            message.AddUniqueArgs(new Dictionary<string, string>() { { "key", "value" } });
            Assert.IsFalse(string.IsNullOrEmpty(message.Header.JsonString()));
            Assert.AreEqual(message.Header.JsonString(), mail.Header.JsonString());
        }
        [TestMethod]
        public void Test_IncludeUniqueArgs() {
            var args = new Dictionary<string, string>() {
                { "key1", "value"},
                { "key2", "eulav" }
            };
            var mail = BasicMailBuilder
                .IncludeUniqueArgs(args)
                .Build();

            var message = new SendGridMessage();

            message.AddUniqueArgs(args);
            Assert.IsFalse(string.IsNullOrEmpty(message.Header.JsonString()));
            Assert.AreEqual(message.Header.JsonString(), mail.Header.JsonString());
        }
        #endregion

        #region To, Cc, Bcc, and From Methods
        [TestMethod]
        public void Test_Bcc_mailaddresscollection() {
            var netMailMessage = new MailMessage();
            netMailMessage.Bcc.Add("bcc1@example.com,bcc2@example.com,bcc3@example.com");

            var mail = BasicMailBuilder
                .Bcc(netMailMessage.Bcc)
                .Build();

            var message = new SendGridMessage();
            message.Bcc = new MailAddress[] { 
                netMailMessage.Bcc[0],
                netMailMessage.Bcc[1],
                netMailMessage.Bcc[2],
            };
            CollectionAssert.AreEquivalent(message.Bcc, mail.Bcc);
        }
        [TestMethod]
        public void Test_Bcc_listmailaddress() {
            var addresses = new List<MailAddress>() {
                new MailAddress("bcc1@example.com"),
                new MailAddress("bcc2@example.com")
            };
            var mail = BasicMailBuilder
                .Bcc(addresses)
                .Build();

            var message = new SendGridMessage();
            message.Bcc = new MailAddress[] { 
                addresses[0],
                addresses[1] 
            };
            CollectionAssert.AreEquivalent(message.Bcc, mail.Bcc);
        }
        [TestMethod]
        public void Test_Bcc_liststring() {
            var addresses = new List<string>() {
                "bcc1@example.com",
                "bcc2@example.com"
            };

            var mail = BasicMailBuilder
                .Bcc(addresses)
                .Build();

            var message = new SendGridMessage();
            message.Bcc = new MailAddress[] { 
                new MailAddress(addresses[0]),
                new MailAddress(addresses[1]) 
            };
            CollectionAssert.AreEquivalent(message.Bcc, mail.Bcc);
        }
        [TestMethod]
        public void Test_Bcc_mailaddress() {
            var address = new MailAddress("bcc@example.com");
            var mail = BasicMailBuilder
                .Bcc(address)
                .Build();

            var message = new SendGridMessage();
            message.Bcc = new MailAddress[] { address };
            CollectionAssert.AreEquivalent(message.Bcc, mail.Bcc);
        }
        [TestMethod]
        public void Test_Bcc_email() {
            var mail = BasicMailBuilder
                .Bcc("bcc@example.com")
                .Build();

            var message = new SendGridMessage();
            message.Bcc = new MailAddress[] { new MailAddress("bcc@example.com") };
            CollectionAssert.AreEquivalent(message.Bcc, mail.Bcc);
        }
        [TestMethod]
        public void Test_Bcc_email_display() {
            var mail = BasicMailBuilder
                .Bcc("bcc@example.com", "Jack Fetcher")
                .Build();

            var message = new SendGridMessage();
            message.Bcc = new MailAddress[] { new MailAddress("bcc@example.com", "Jack Fetcher") };
            CollectionAssert.AreEquivalent(message.Bcc, mail.Bcc);
        }

        [TestMethod]
        public void Test_Cc_mailaddresscollection() {
            var netMailMessage = new MailMessage();
            netMailMessage.CC.Add("cc1@example.com,cc2@example.com,cc3@example.com");

            var mail = BasicMailBuilder
                .Cc(netMailMessage.CC)
                .Build();

            var message = new SendGridMessage();
            message.Cc = new MailAddress[] { 
                netMailMessage.CC[0],
                netMailMessage.CC[1],
                netMailMessage.CC[2],
            };
            CollectionAssert.AreEquivalent(message.Cc, mail.Cc);
        }
        [TestMethod]
        public void Test_Cc_listmailaddress() {
            var addresses = new List<MailAddress>() {
                new MailAddress("cc1@example.com"),
                new MailAddress("cc2@example.com")
            };
            var mail = BasicMailBuilder
                .Cc(addresses)
                .Build();

            var message = new SendGridMessage();
            message.Cc = new MailAddress[] { 
                addresses[0],
                addresses[1] 
            };
            CollectionAssert.AreEquivalent(message.Cc, mail.Cc);
        }
        [TestMethod]
        public void Test_Cc_liststring() {
            var addresses = new List<string>() {
                "cc1@example.com",
                "cc2@example.com"
            };

            var mail = BasicMailBuilder
                .Cc(addresses)
                .Build();

            var message = new SendGridMessage();
            message.Cc = new MailAddress[] { 
                new MailAddress(addresses[0]),
                new MailAddress(addresses[1]) 
            };
            CollectionAssert.AreEquivalent(message.Cc, mail.Cc);
        }
        [TestMethod]
        public void Test_Cc_mailaddress() {
            var address = new MailAddress("cc@example.com");
            var mail = BasicMailBuilder
                .Cc(address)
                .Build();

            var message = new SendGridMessage();
            message.Cc = new MailAddress[] { address };
            CollectionAssert.AreEquivalent(message.Cc, mail.Cc);
        }
        [TestMethod]
        public void Test_Cc_email() {
            var mail = BasicMailBuilder
                .Cc("cc@example.com")
                .Build();

            var message = new SendGridMessage();
            message.Cc = new MailAddress[] { new MailAddress("cc@example.com") };
            CollectionAssert.AreEquivalent(message.Cc, mail.Cc);
        }
        [TestMethod]
        public void Test_Cc_email_display() {
            var mail = BasicMailBuilder
                .Cc("cc@example.com", "Jack Fetcher")
                .Build();

            var message = new SendGridMessage();
            message.Cc = new MailAddress[] { new MailAddress("cc@example.com", "Jack Fetcher") };
            CollectionAssert.AreEquivalent(message.Cc, mail.Cc);
        }

        [TestMethod]
        public void Test_To_mailaddresscollection() {
            var netMailMessage = new MailMessage();
            netMailMessage.To.Add("to1@example.com,to2@example.com,to3@example.com");

            var mail = BasicMailBuilder_NoTo
                .To(netMailMessage.To)
                .Build();

            var message = new SendGridMessage();
            message.To = new MailAddress[] { 
                netMailMessage.To[0],
                netMailMessage.To[1],
                netMailMessage.To[2],
            };
            CollectionAssert.AreEquivalent(message.To, mail.To);
        }
        [TestMethod]
        public void Test_To_listmailaddress() {
            var addresses = new List<MailAddress>() {
                new MailAddress("to1@example.com"),
                new MailAddress("to2@example.com")
            };
            var mail = BasicMailBuilder_NoTo
                .To(addresses)
                .Build();

            var message = new SendGridMessage();
            message.To = new MailAddress[] { 
                addresses[0],
                addresses[1] 
            };
            CollectionAssert.AreEquivalent(message.To, mail.To);
        }
        [TestMethod]
        public void Test_To_liststring() {
            var addresses = new List<string>() {
                "to1@example.com",
                "to2@example.com"
            };

            var mail = BasicMailBuilder_NoTo
                .To(addresses)
                .Build();

            var message = new SendGridMessage();
            message.To = new MailAddress[] { 
                new MailAddress(addresses[0]),
                new MailAddress(addresses[1]) 
            };
            CollectionAssert.AreEquivalent(message.To, mail.To);
        }
        [TestMethod]
        public void Test_To_mailaddress() {
            var address = new MailAddress("to@example.com");
            var mail = BasicMailBuilder_NoTo
                .To(address)
                .Build();

            var message = new SendGridMessage();
            message.To = new MailAddress[] { address };
            CollectionAssert.AreEquivalent(message.To, mail.To);
        }
        [TestMethod]
        public void Test_To_email() {
            var mail = BasicMailBuilder_NoTo
                .To("to@example.com")
                .Build();

            var message = new SendGridMessage();
            message.To = new MailAddress[] { new MailAddress("to@example.com") };
            CollectionAssert.AreEquivalent(message.To, mail.To);
        }
        [TestMethod]
        public void Test_To_email_display() {
            var mail = BasicMailBuilder_NoTo
                .To("to@example.com", "Jack Fetcher")
                .Build();

            var message = new SendGridMessage();
            message.To = new MailAddress[] { new MailAddress("to@example.com", "Jack Fetcher") };
            CollectionAssert.AreEquivalent(message.To, mail.To);
        }

        [TestMethod]
        public void Test_From_email() {
            var mail = BasicMailBuilder_NoFrom
                .From("from@example.com")
                .Build();

            var message = new SendGridMessage();
            message.From = new MailAddress("from@example.com");
            Assert.AreEqual(message.From, mail.From);
        }
        [TestMethod]
        public void Test_From_email_display() {
            var mail = BasicMailBuilder_NoFrom
                .From("from@example.com", "Test Person")
                .Build();

            var message = new SendGridMessage();
            message.From = new MailAddress("from@example.com", "Test Person");
            Assert.AreEqual(message.From, mail.From);
        }
        [TestMethod]
        public void Test_From_mailmessage() {
            var mail = BasicMailBuilder_NoFrom
                .From(new MailAddress("from@example.com", "Test Person"))
                .Build();

            var message = new SendGridMessage();
            message.From = new MailAddress("from@example.com", "Test Person");
            Assert.AreEqual(message.From, mail.From);
        }
        #endregion

        #region Body Methods
        [TestMethod]
        public void Test_Html_alternateview() {
            var html = "<h2>Testing</h2><p>Testing HTML in the MailBuilder";
            var av = AlternateView.CreateAlternateViewFromString(html);

            var mail = BasicMailBuilder_NoText
                .Html(av)
                .Build();

            var message = new SendGridMessage();
            message.Html = html;
            Assert.AreEqual(message.Html, mail.Html);
        }
        [TestMethod]
        public void Test_Html_html() {
            var html = "<h2>Testing</h2><p>Testing HTML in the MailBuilder";

            var mail = BasicMailBuilder_NoText
                .Html(html)
                .Build();

            var message = new SendGridMessage();
            message.Html = html;
            Assert.AreEqual(message.Html, mail.Html);
        }
        [TestMethod]
        public void Test_Text_alternateview() {
            var text = "Testing HTML in the MailBuilder";
            var av = AlternateView.CreateAlternateViewFromString(text);

            var mail = BasicMailBuilder_NoText
                .Text(text)
                .Build();

            var message = new SendGridMessage();
            message.Text = text;
            Assert.AreEqual(message.Text, mail.Text);
        }
        [TestMethod]
        public void Test_Text_text() {
            var text = "Testing HTML in the MailBuilder";

            var mail = BasicMailBuilder_NoText
                .Text(text)
                .Build();

            var message = new SendGridMessage();
            message.Text = text;
            Assert.AreEqual(message.Text, mail.Text);
        }
        [TestMethod]
        public void Test_Subject() {
            var mail = BasicMailBuilder_NoSubject
                .Subject("Test Subject")
                .Build();

            var message = new SendGridMessage();
            message.Subject = "Test Subject";
            Assert.AreEqual(message.Subject, mail.Subject);
        }

        [TestMethod]
        public void Test_AttachFile_filepath() {
            var filename = Path.GetTempFileName();
            var mail = BasicMailBuilder
                .AttachFile(filename)
                .Build();

            var message = new SendGridMessage();
            message.AddAttachment(filename);
            CollectionAssert.AreEquivalent(message.Attachments, mail.Attachments);
            CollectionAssert.AreEquivalent(message.StreamedAttachments, mail.StreamedAttachments);
        }
        [TestMethod]
        public void Test_AttachFile_attachment() {
            var filename = Path.GetTempFileName();
            var attachment = new Attachment(filename);
            var mail = BasicMailBuilder
                .AttachFile(attachment)
                .Build();

            var message = new SendGridMessage();
            message.AddAttachment(attachment.ContentStream, attachment.Name);
            Assert.AreEqual(1, message.StreamedAttachments.Count);
            Assert.AreEqual(1, mail.StreamedAttachments.Count);
            Assert.IsTrue(message.StreamedAttachments.ContainsKey(attachment.Name));
            Assert.IsTrue(mail.StreamedAttachments.ContainsKey(attachment.Name));
            Assert.AreEqual(message.StreamedAttachments[attachment.Name].Length, mail.StreamedAttachments[attachment.Name].Length);
        }
        [TestMethod]
        public void Test_AttachFile_stream_filename() {
            var filename = Path.GetTempFileName();
            var attachment = new Attachment(filename);
            var mail = BasicMailBuilder
                .AttachFile(attachment.ContentStream, attachment.Name)
                .Build();

            var message = new SendGridMessage();
            message.AddAttachment(attachment.ContentStream, attachment.Name);
            Assert.AreEqual(1, message.StreamedAttachments.Count);
            Assert.AreEqual(1, mail.StreamedAttachments.Count);
            Assert.IsTrue(message.StreamedAttachments.ContainsKey(attachment.Name));
            Assert.IsTrue(mail.StreamedAttachments.ContainsKey(attachment.Name));
            Assert.AreEqual(message.StreamedAttachments[attachment.Name].Length, mail.StreamedAttachments[attachment.Name].Length);
        }
        [TestMethod]
        public void Test_AttachFile_listattachment() {
            var filenames = new string[] { Path.GetTempFileName(), Path.GetTempFileName() };
            List<Attachment> attachments = filenames.ToList().ConvertAll<Attachment>((x) => { return new Attachment(x); });
            var mail = BasicMailBuilder
                .AttachFiles(attachments)
                .Build();

            var message = new SendGridMessage();
            message.AddAttachment(attachments[0].ContentStream, attachments[0].Name);
            message.AddAttachment(attachments[1].ContentStream, attachments[1].Name);
            Assert.AreEqual(2, message.StreamedAttachments.Count);
            Assert.AreEqual(2, mail.StreamedAttachments.Count);
            Assert.IsTrue(message.StreamedAttachments.ContainsKey(attachments[0].Name));
            Assert.IsTrue(message.StreamedAttachments.ContainsKey(attachments[1].Name));
            Assert.IsTrue(mail.StreamedAttachments.ContainsKey(attachments[0].Name));
            Assert.IsTrue(mail.StreamedAttachments.ContainsKey(attachments[1].Name));
            Assert.AreEqual(message.StreamedAttachments[attachments[0].Name].Length, mail.StreamedAttachments[attachments[0].Name].Length);
            Assert.AreEqual(message.StreamedAttachments[attachments[1].Name].Length, mail.StreamedAttachments[attachments[1].Name].Length);
        }
        [TestMethod]
        public void Test_AttachFile_attachmentcollection() {
            var filename = Path.GetTempFileName();
            var attachment = new Attachment(filename);
            var netMailMessage = new MailMessage();
            netMailMessage.Attachments.Add(attachment);

            var mail = BasicMailBuilder
                .AttachFiles(netMailMessage.Attachments)
                .Build();

            var message = new SendGridMessage();
            message.AddAttachment(attachment.ContentStream, attachment.Name);
            Assert.AreEqual(1, message.StreamedAttachments.Count);
            Assert.AreEqual(1, mail.StreamedAttachments.Count);
            Assert.IsTrue(message.StreamedAttachments.ContainsKey(attachment.Name));
            Assert.IsTrue(mail.StreamedAttachments.ContainsKey(attachment.Name));
            Assert.AreEqual(message.StreamedAttachments[attachment.Name].Length, mail.StreamedAttachments[attachment.Name].Length);
        }

        [TestMethod]
        public void Test_EmbedImage_filepath_cid() {
            var filename = Path.GetTempFileName();
            var cid = "image1.jpg@example.com";
            var mail = BasicMailBuilder
                .EmbedImage(filename, cid)
                .Build();

            var message = new SendGridMessage();
            message.AddAttachment(filename);
            message.EmbedImage(new FileInfo(filename).Name, cid);

            CollectionAssert.AreEquivalent(message.GetEmbeddedImages().ToList(), mail.GetEmbeddedImages().ToList());
            CollectionAssert.AreEquivalent(message.Attachments, mail.Attachments);
            CollectionAssert.AreEquivalent(message.StreamedAttachments, mail.StreamedAttachments);
        }
        [TestMethod]
        public void Test_EmbedImage_linkedresource() {
            var filename = Path.GetTempFileName();
            var attachment = new Attachment(filename);
            var linkedResource = new LinkedResource(filename);

            var mail = BasicMailBuilder
                .EmbedImage(linkedResource)
                .Build();

            var message = new SendGridMessage();
            message.AddAttachment(attachment.ContentStream, attachment.Name);
            message.EmbedImage(linkedResource.ContentId, linkedResource.ContentId);
            CollectionAssert.AreEquivalent(message.GetEmbeddedImages().ToList(), mail.GetEmbeddedImages().ToList());
            Assert.AreEqual(1, message.StreamedAttachments.Count);
            Assert.AreEqual(1, mail.StreamedAttachments.Count);
            Assert.AreEqual(message.StreamedAttachments.First().Value.Length, mail.StreamedAttachments.First().Value.Length);
        }
        [TestMethod]
        public void Test_EmbedImage_listlinkedresource() {
            var filename = new string[] { Path.GetTempFileName(), Path.GetTempFileName() };
            var attachments = filename.ToList().ConvertAll<Attachment>((x) => { return new Attachment(x); });
            var linkedResources = filename.ToList().ConvertAll<LinkedResource>((x) => { return new LinkedResource(x); });

            var mail = BasicMailBuilder
                .EmbedImages(linkedResources)
                .Build();

            var message = new SendGridMessage();
            message.AddAttachment(attachments[0].ContentStream, attachments[0].Name);
            message.AddAttachment(attachments[1].ContentStream, attachments[1].Name);
            message.EmbedImage(linkedResources[0].ContentId, linkedResources[0].ContentId);
            message.EmbedImage(linkedResources[1].ContentId, linkedResources[1].ContentId);
            CollectionAssert.AreEquivalent(message.GetEmbeddedImages().ToList(), mail.GetEmbeddedImages().ToList());
            Assert.AreEqual(2, message.StreamedAttachments.Count);
            Assert.AreEqual(2, mail.StreamedAttachments.Count);
            Assert.AreEqual(message.StreamedAttachments.First().Value.Length, mail.StreamedAttachments.First().Value.Length);
            Assert.AreEqual(message.StreamedAttachments.Last().Value.Length, mail.StreamedAttachments.Last().Value.Length);
        }
        [TestMethod]
        public void Test_EmbedImage_linkedresourcecollection() {
            var filename = Path.GetTempFileName();
            var attachment = new Attachment(filename);
            var av = AlternateView.CreateAlternateViewFromString("Testing");
            av.LinkedResources.Add(new LinkedResource(filename));

            var mail = BasicMailBuilder
                .EmbedImages(av.LinkedResources)
                .Build();

            var message = new SendGridMessage();
            message.AddAttachment(attachment.ContentStream, attachment.Name);
            message.EmbedImage(av.LinkedResources[0].ContentId, av.LinkedResources[0].ContentId);
            CollectionAssert.AreEquivalent(message.GetEmbeddedImages().ToList(), mail.GetEmbeddedImages().ToList());
            Assert.AreEqual(1, message.StreamedAttachments.Count);
            Assert.AreEqual(1, mail.StreamedAttachments.Count);
            Assert.AreEqual(message.StreamedAttachments.First().Value.Length, mail.StreamedAttachments.First().Value.Length);
        }
        #endregion

        [TestMethod]
        public void Test_HideRecipients() {
            var mail = BasicMailBuilder_NoTo
                .To("frank@example.com")
                .To("joe@example.com")
                .HideRecipients()
                .Build();

            var message = new SendGridMessage();
            message.Header.SetTo(new List<string>() { "frank@example.com", "joe@example.com" });
            Assert.IsFalse(string.IsNullOrEmpty(message.Header.JsonString()));
            Assert.AreEqual(message.Header.JsonString(), mail.Header.JsonString());
        }

        [TestMethod]
        [ExpectedException(typeof(AggregateException))]
        public void Test_Method1() {
            var mail = MailBuilder.Create()
                .Build();
        }
    }
}
