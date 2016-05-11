using System.Net;
using System.Net.Mail;
using System.Text;
using UVM.Theatre.Domain.Models;

namespace UVM.Theatre.Services
{
    public class OrderProcessorService
    {
        public class EmailSettings
        {
            public string MailToAddress = "orders@example.com";
            public string MailFromAddress = "sportsstore@example.com";
            public bool UseSsl = true;
            public string Username = "MySmtpUsername";
            public string Password = "MySmtpPassword";
            public string ServerName = "smtp.example.com";
            public int ServerPort = 587;
            public bool WriteAsFile = true;
            public string FileLocation = @"c:\sports_store_emails";
        }

        public class EmailOrderProcessor : IOrderProcessorService
        {
            private readonly EmailSettings _emailSettings;

            public EmailOrderProcessor(EmailSettings settings)
            {
                _emailSettings = settings;
            }

            public void ProcessOrder(Cart cart, ShippingDetails shippingInfo)
            {

                using (var smtpClient = new SmtpClient())
                {

                    smtpClient.EnableSsl = _emailSettings.UseSsl;
                    smtpClient.Host = _emailSettings.ServerName;
                    smtpClient.Port = _emailSettings.ServerPort;
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials
                        = new NetworkCredential(_emailSettings.Username,
                              _emailSettings.Password);

                    if (_emailSettings.WriteAsFile)
                    {
                        smtpClient.DeliveryMethod
                            = SmtpDeliveryMethod.SpecifiedPickupDirectory;
                        smtpClient.PickupDirectoryLocation = _emailSettings.FileLocation;
                        smtpClient.EnableSsl = false;
                    }

                    StringBuilder body = new StringBuilder()
                        .AppendLine("A new order has been submitted")
                        .AppendLine("---")
                        .AppendLine("Items:");

                    foreach (var line in cart.Lines)
                    {
                        
                        var studentSubtotal = line.Show.StudentPrice * line.StudentQuantity;
                        var seniorSubtotal = line.Show.SeniorPrice * line.SeniorQuantity;
                        var regularSubtotal = line.Show.RegularPrice * line.RegularQuantity;
                        var subtotal = studentSubtotal + seniorSubtotal + regularSubtotal;
                        body.Append($"{line.StudentQuantity} x {line.Show.StudentPrice} (subtotal: {studentSubtotal:c}");
                        body.Append($"{line.SeniorQuantity} x {line.Show.SeniorPrice} (subtotal: {seniorSubtotal:c}");
                        body.Append($"{line.RegularQuantity} x {line.Show.RegularPrice} (subtotal: {regularSubtotal:c}");
                        body.Append($"Total {subtotal:c}");
                    }

                    body.AppendFormat("Total order value: {0:c}", cart.ComputeTotalValue())
                        .AppendLine("---")
                        .AppendLine("Ship to:")
                        .AppendLine(shippingInfo.Name)
                        .AppendLine(shippingInfo.Line1)
                        .AppendLine(shippingInfo.Line2 ?? "")
                        .AppendLine(shippingInfo.Line3 ?? "")
                        .AppendLine(shippingInfo.City)
                        .AppendLine(shippingInfo.State ?? "")
                        .AppendLine(shippingInfo.Country)
                        .AppendLine(shippingInfo.Zip)
                        .AppendLine("---")
                        .Append($"Gift wrap: {(shippingInfo.GiftWrap ? "Yes" : "No")}");

                    var mailMessage = new MailMessage(
                                           _emailSettings.MailFromAddress,   // From
                                           _emailSettings.MailToAddress,     // To
                                           "New order submitted!",          // Subject
                                           body.ToString());                // Body

                    if (_emailSettings.WriteAsFile)
                    {
                        mailMessage.BodyEncoding = Encoding.ASCII;
                    }

                    smtpClient.Send(mailMessage);
                }
            }
        }

        public void ProcessOrder(Cart cart, ShippingDetails shippingDetails)
        {
            throw new System.NotImplementedException();
        }
    }
}