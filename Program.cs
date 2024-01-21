using System.Net.Mail;

using (SmtpClient client = new SmtpClient("mailslurper"))
{
    client.Port = 2500;

    using (MailMessage message = new MailMessage())
    {
        message.From = new MailAddress("sender@example.com");
        message.To.Add(new MailAddress("recipient@example.com"));

        message.Subject = "Test Email";
        message.Body = "This is a test email.";
        try
        {
            client.Send(message);
            Console.WriteLine("Email sent successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error sending email: {ex.Message}");
            Console.WriteLine(ex);
        }
    }
}
